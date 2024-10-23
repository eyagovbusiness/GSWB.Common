@Library('standard-library') _

pipeline {
    agent {
        label 'imagechecker'
    }
    environment {
        REGISTRY='registry.guildswarm.org'
        // TBD - ENVIRONMENT='Testportal' change to ENVIRONMENT='testportal' on software
        ENVIRONMENT = "${env.BRANCH_NAME == 'integration' ? 'staging' : (env.BRANCH_NAME == 'main' || env.BRANCH_NAME == 'master') ? 'production' : env.BRANCH_NAME}"
        IMAGE='common'
    }
    stages {
        stage('Build Docker Images') {
            steps {
                script {
                    def VERSION = readFile('version').trim()
                    env.VERSION = VERSION
                    sh ''' 
                        find . \\( -name "*.csproj" -o -name "*.sln" -o -name "NuGet.docker.config" \\) -print0 \
                        | tar -cvf projectfiles.tar -T -
                    '''
                    try {
                        withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: "harbor-${ENVIRONMENT}", usernameVariable: 'DOCKER_USERNAME', passwordVariable: 'DOCKER_PASSWORD']]) {
                            sh "docker login -u \'${DOCKER_USERNAME}' -p \'${DOCKER_PASSWORD}' ${REGISTRY}"
                            sh "docker build . --build-arg ENVIRONMENT='${ENVIRONMENT}' -t ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:${VERSION} -t ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:latest"
                            sh 'docker logout'
                        }
                    } finally {
                        sh "rm -f projectfiles.tar"
                    }
                }
            }
        }
        stage('Test Vulnerabilities') {
            steps {
                script {
                    if (env.CHANGE_ID == null) {
                        sh "trivy image --quiet --exit-code 1 ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:latest"
                    } else {
                        echo "Avoiding Scan in PR"
                    }
                }
            }
        }
        stage('Push Docker Images') {
            steps {
                script {
                    if (env.CHANGE_ID == null) {
                        withCredentials([[$class: 'UsernamePasswordMultiBinding', credentialsId: "harbor-${ENVIRONMENT}", usernameVariable: 'DOCKER_USERNAME', passwordVariable: 'DOCKER_PASSWORD']]) {
                            sh "docker login -u \'${DOCKER_USERNAME}' -p \'${DOCKER_PASSWORD}' ${REGISTRY}"
                            sh "docker push ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:${VERSION}"
                            sh "docker push ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:latest"
                            sh 'docker logout'
                        }
                    } else {
                        echo "Avoiding push for PR"
                    }
                }
            }
        }
        stage('Remove Docker Images') {
            steps {
                script {
                    sh "docker rmi ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:${VERSION}"
                    sh "docker rmi ${REGISTRY}/${ENVIRONMENT}/${IMAGE}:latest"
                }
            }
        }
    }
    post {
        always {
            sh 'rm -rf *'
        }
        success {
            script {
                build job: "backend/GSWB.ApiGateway/${ENVIRONMENT}", wait: false
                build job: "backend/GSWB.SwarmBot/${ENVIRONMENT}", wait: false
                build job: "backend/GSWB.Members/${ENVIRONMENT}", wait: false
            }
        }
        failure {
            script {
                pga.slack_webhook("backend")
            }
        }
    }
}

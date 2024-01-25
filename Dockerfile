ARG BUILD_CONFIGURATION=Release
FROM registry.guildswarm.org/base-images/thegoodframework:latest AS base

# BUILD IMAGE
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build 
ARG BUILD_CONFIGURATION
WORKDIR /src
# Copy NuGet packages from the base image
COPY --from=base /app/BasePackages ./BasePackages
# Copy project files archive
COPY projectfiles.tar .
# Restore dependencies in a docker cache friendly way
RUN tar -xvf projectfiles.tar \
    && dotnet restore "GSWB.Common.sln" --configfile ./NuGet.docker.config /p:DockerBuild=true -r linux-musl-x64 \
    && rm projectfiles.tar  # Remove the tar file to reduce image size
# Copy the rest of the source code
COPY . .
## Build and package each project as a NuGet package
RUN dotnet build "GSWB.Common.sln" -c $BUILD_CONFIGURATION --no-restore /p:DockerBuild=true \
    && dotnet pack "GSWB.Common.sln" -c $BUILD_CONFIGURATION --no-build -o /src/CommonPackages /p:DockerBuild=true

# FINAL STAGE/IMAGE
FROM base AS final
WORKDIR /app/BasePackages
COPY --from=build /src/CommonPackages ./CommonPackages
COPY --from=build /root/.nuget/packages ./CommonRestored

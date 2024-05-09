using Common.Application.Contracts.Services;
using Common.Application.DTOs.Auth;
using Common.Application.DTOs.Members;
using Common.Infrastructure.Communication.ApiRoutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGF.CA.Infrastructure.Communication.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP;
using TGF.Common.ROP.HttpResult;

namespace Common.Infrastructure.Communication.HTTP
{
    public class AllowMeCommunicationService : HttpCommunicationService, IAllowMeCommunicationService
    {
        private readonly string _serviceName;
        public AllowMeCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory)
        : base(aServiceDiscovery, aHttpClientFactory)
            => _serviceName = ServicesDiscoveryNames.AllowMe;

        public async Task<IHttpResult<string>> AllowUser(string aId, CancellationToken aCancellationToken = default)
            => await PutAsync<string, string>(_serviceName, AllowMeApiRoutes.allow_me, aId, aCancellationToken);
    }
}

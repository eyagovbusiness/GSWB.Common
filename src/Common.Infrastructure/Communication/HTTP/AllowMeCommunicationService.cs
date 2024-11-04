using Common.Application.Communication.Routing;
using Common.Application.Contracts.Services;
using TGF.CA.Infrastructure.Comm.Http;
using TGF.CA.Infrastructure.Discovery;
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
            => await PutAsync<string, string>(_serviceName, AllowMeApiRoutes.allow_me, aId, aCancellationToken: aCancellationToken);
    }
}

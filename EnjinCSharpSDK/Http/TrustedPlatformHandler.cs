using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace EnjinSDK.Http
{
    public class TrustedPlatformHandler : HttpClientHandler
    {
        private readonly string _agent;
        private string _authToken;

        public string AuthToken
        {
            set => _authToken = value;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(_authToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _authToken);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
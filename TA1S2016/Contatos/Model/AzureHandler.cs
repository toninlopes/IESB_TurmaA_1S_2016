using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Contatos.Model
{
    public class AzureHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage>SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("ZUMO-API-VERSION", "2.0.0");
            return base.SendAsync(request, cancellationToken);
        }
    }
}

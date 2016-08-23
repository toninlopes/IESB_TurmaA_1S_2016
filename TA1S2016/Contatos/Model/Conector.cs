using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http.Filters;
using Windows.Web.Http.Headers;

namespace Contatos.Model
{
    public static class Conector
    {
        public static async Task<string> SendRequestAsync(
            Windows.Web.Http.HttpRequestMessage httpRequest)
        {
            HttpBaseProtocolFilter filter =
                new HttpBaseProtocolFilter();
            filter.CacheControl.ReadBehavior =
                Windows.Web.Http.Filters.HttpCacheReadBehavior.MostRecent;
            filter.CacheControl.WriteBehavior =
                Windows.Web.Http.Filters.HttpCacheWriteBehavior.NoCache;

            using (Windows.Web.Http.HttpClient httpClient =
                new Windows.Web.Http.HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept
                    .Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders
                    .Add("ZUMO-API-VERSION", "2.0.0");
                try
                {
                    using (Windows.Web.Http.HttpResponseMessage response =
                        await httpClient.SendRequestAsync(httpRequest))
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        response.EnsureSuccessStatusCode();
                        return result;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}

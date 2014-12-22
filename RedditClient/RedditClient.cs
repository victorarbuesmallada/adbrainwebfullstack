using log4net;
using Reddit.DataTransfer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient
{
    /// <summary>
    /// Implementation of the reddit client interface
    /// </summary>
    public class RedditClient : IRedditClient
    {
        private static readonly string _redditUrlBase = ConfigurationManager.AppSettings["Reddit.Url.Base"];
        private static readonly string _redditUrlGet = ConfigurationManager.AppSettings["Reddit.Url.Get"];

        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(RedditClient));

        public async Task<Response> GetSportItems()
        {
            Log.Info("Retrieving sport items");
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_redditUrlBase);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await httpClient.GetAsync(string.Format(_redditUrlGet, "sports")).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Response>();
                }
                Log.Warn("Couldn't retrieve sport items");
                return null;
            }
        }
    }
}

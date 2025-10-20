using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiAIMaker.Services
{
    public class WebFetchService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private string _url;

        

        public async Task<string> FetchDataAsync(string url)
        {
            _url = url ?? throw new ArgumentNullException(nameof(url));

            try
            {
                using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                Debug.WriteLine($"{content}");
                return content;
            }
            catch (HttpRequestException ex)
            {
                throw new InvalidOperationException($"Chyba při získávání {url}: {ex.Message}", ex);
            }
        }

      
    }
}
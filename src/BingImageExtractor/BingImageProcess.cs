using BingImageExtractor.Entities;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BingImageExtractor
{
    public class BingImageProcess
    {
        private readonly Uri _bingURl = new Uri("https://www.bing.com");

        public async Task<Uri> GetBingImageAsync()
        {
            using var httpClient = new HttpClient();
            httpClient.BaseAddress = _bingURl;

            var bingImageArchive = await httpClient.GetFromJsonAsync<BingImageArchive>("/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US");

            return new Uri($"https://bing.com{bingImageArchive.images[0].url}");
        }
    }
}
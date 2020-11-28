using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TarkovMarket.Exceptions;
using TarkovMarket.Models;

namespace TarkovMarket.Http
{
    internal class Request : IDisposable
    {
        private readonly HttpClient _client;

        public Request(string apiKey)
        {
            _client = new HttpClient { BaseAddress = new Uri("https://tarkov-market.com/api/v1/") };
            _client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Item>> RequestAsync(string request)
        {
            try
            {
                var response = _client.GetAsync(request).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new TarkovMarketException($"Data not retrieve, status code: {response.StatusCode}.");
                }

                var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var result = JsonConvert.DeserializeObject<List<Item>>(responseData, Converter.Settings);

                return result;
            }
            catch (JsonException ex)
            {
                throw new Exception($"Failed to deserialize data: {ex.Message}", ex);
            }
        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
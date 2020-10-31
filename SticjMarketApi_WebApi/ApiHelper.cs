using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace StockMarketApi_WebApi
{
    public static class ApiHelper
    {
        public static HttpClient _apiClient { get; set; }

        /// <summary>
        /// Initialize the api client
        /// </summary>
        public static void InitializeClient()
        {
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri("https://www.alphavantage.co"); // base address, add query after
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}

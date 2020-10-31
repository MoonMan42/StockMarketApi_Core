using Newtonsoft.Json;
using StockMarketApi_Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StockMarketApi_WebApi
{
    public class AlphaProcessor
    {
        public static async Task<StockListModel> LoadCompanyList()
        {
            string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&apikey={APIResource.ApiToken}";

            using (HttpResponseMessage resposne = await ApiHelper._apiClient.GetAsync(url))
            {
                if (resposne.IsSuccessStatusCode)
                {
                    var stocks = await resposne.Content.ReadAsAsync<StockListModel>();

                    return stocks;
                }
                else
                {
                    throw new Exception(resposne.ReasonPhrase);
                }
            }
        }
    }
}

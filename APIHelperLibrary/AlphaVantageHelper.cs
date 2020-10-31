using ServiceStack;
using StockMarketApi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHelperLibrary
{
    public static class AlphaVantageHelper
    {
        public static async Task<List<StockListModel>> GetStockList()
        {
            List<StockListModel> results;

            results = $"https://www.alphavantage.co/query?function=LISTING_STATUS&apikey={APIResource.ApiToken}"
                .GetStringFromUrl().FromCsv<List<StockListModel>>();

            return results;
        }


    }
}

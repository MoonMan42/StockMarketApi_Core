using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIHelperLibrary
{
    // add ServiceStack.Text nuget package
    public static class StockHelper
    {

        public static List<StockModel> GetStocks(string symbol)
        {
            var results = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={ApiResource.Token}&datatype=csv"
                .GetStringFromUrl().FromCsv<List<StockModel>>();

            return results;
        }
    }
}

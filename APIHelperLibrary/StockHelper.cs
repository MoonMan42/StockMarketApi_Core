using APIModels;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIHelperLibrary
{
    // add ServiceStack.Text nuget package
    //https://www.alphavantage.co/documentation/
    //https://medium.com/@mark.holdt/alphavantage-and-c-1d560e690387
    public static class StockHelper
    {


        public async static Task<List<StockModel>> GetStocksDayStartAndEnd(string symbol)
        {
            try
            {
                var results = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={ApiResource.Token}&datatype=csv"
                    .GetStringFromUrl().FromCsv<List<StockModel>>();

                return results;
            }
            catch
            {
                throw new Exception();
            }
        }

        public async static Task<List<StockSymbolModel>> GetStockSymbolList(string symbol = "M")
        {

            //https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords=BA&apikey=demo&datatype=csv
            try
            {
                var r = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={symbol}&apikey={ApiResource.Token}&datatype=csv".GetStringFromUrl().FromCsv<List<StockSymbolModel>>();

                return r;
            }
            catch
            {
                throw new Exception();
            }
        }
    }

}

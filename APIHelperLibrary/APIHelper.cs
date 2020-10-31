//using ServiceStack;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace APIHelperLibrary
//{
//    public static class APIHelper
//    {
//        public static async Task<List<SymbolModel>> SearchSymbol(string symbol)
//        {

//            if (!symbol.IsNullOrEmpty())
//            {
//                try
//                {

//                    var results = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={symbol}&apikey={APIResource.ApiToken}&datatype=csv"
//                        .GetStringFromUrl().FromCsv<List<SymbolModel>>();
//                    return results;


//                }
//                catch (WebException wex)
//                {
//                    // do nothing
//                    return null;
//                }
//                catch
//                {
//                    //throw new Exception();
//                    return null;
//                }
//            }


//            return null;
//        }

//        public static async Task<List<DailyStockModel>> GetDailyStats(string symbol)
//        {
//            List<DailyStockModel> results = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={APIResource.ApiToken}&datatype=csv"
//                .GetStringFromUrl().FromCsv<List<DailyStockModel>>();

//            return results;
//        }

//        public static async Task<List<DailyStockModel>> GetDailyStocks(string symbol)
//        {
//            List<DailyStockModel> results;

//            results = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={symbol}&apikey={APIResource.ApiToken}&datatype=csv"
//                        .GetStringFromUrl().FromCsv<List<DailyStockModel>>();

//            results = ($"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={APIResource.ApiToken}&datatype=csv"
//                        .GetStringFromUrl().FromCsv<List<DailyStockModel>>());

//            return results;

//        }
//    }
//}

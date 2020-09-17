using ServiceStack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIHelperLibrary
{
    public static class APIHelper
    {
        public static async Task<List<SymbolModel>> SearchSymbol(string symbol)
        {

            if (!symbol.IsNullOrEmpty())
            {
                try
                {

                    var results = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={symbol}&apikey={APIResource.ApiToken}&datatype=csv"
                        .GetStringFromUrl().FromCsv<List<SymbolModel>>();
                    return results;


                }
                catch (WebException wex)
                {
                    // do nothing
                    return null;
                }
                catch
                {
                    //throw new Exception();
                    return null;
                }
            }


            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketApi_Models
{
    public class StockListModel
    {
        //symbol,name,exchange,assetType,ipoDate,delistingDate,status
        public string Symbol { get; set; }
        public string Name { get; set; }


        public StockListModel(string symb, string name)
        {
            Symbol = symb;
            Name = name;
        }
    }
}

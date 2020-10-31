using StockMarketApi_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockMarketApi_Wpf.Helpers
{
    /// <summary>
    /// Cache the symbol list for future use
    /// </summary>
    public class CsvHelper
    {
        private string csvFilePath;

        public CsvHelper(string csvFile)
        {
            csvFilePath = csvFile;
        }

        public List<StockListModel> LoadSymbolCsv()
        {
            List<StockListModel> results = new List<StockListModel>();

            using (StreamReader r = new StreamReader(csvFilePath))
            {
                while (!r.EndOfStream)
                {
                    var line = r.ReadLine();
                    var values = line.Split(',');
                    results.Add(new StockListModel(values[0], values[1]));
                }
            }

            return results;
        }

        public void SaveSymbolsCsv(List<StockListModel> stockSymbols)
        {
            using (var w = new StreamWriter(csvFilePath))
            {
                foreach (var s in stockSymbols)
                {
                    var str = string.Format($"{s.Symbol}, {s.Name}");
                    w.WriteLine(str);
                    w.Flush();
                }
            }
        }
    }
}

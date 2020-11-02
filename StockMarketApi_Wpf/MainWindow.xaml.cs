using APIHelperLibrary;
using StockMarketApi_Models;
using StockMarketApi_Wpf.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockMarketApi_Wpf
{

    public partial class MainWindow : Window
    {
        private CsvHelper csvHelper;
        private string csvFile = "StockSymbols.csv";

        private List<StockListModel> stockSymbols = new List<StockListModel>();

        public MainWindow()
        {
            InitializeComponent();

            csvHelper = new CsvHelper(csvFile);

            LoadSymbolList();
        }

        private void LoadSymbolList()
        {

            if (File.Exists(csvFile))
            {
                // file exist load the list
                stockSymbols = csvHelper.LoadSymbolCsv();
            }
            else
            {
                // file does not exit download and save to csv
                stockSymbols = AlphaVantageHelper.GetStockList().Result;
                csvHelper.SaveSymbolsCsv(stockSymbols);
            }

            // show list
            Symbol_ListView.ItemsSource = stockSymbols;
        }

        #region Header Commands
        private void ReloadSymbols_Click(object sender, RoutedEventArgs e)
        {
            // download the list and save to csv
            stockSymbols = AlphaVantageHelper.GetStockList().Result;
            csvHelper.SaveSymbolsCsv(stockSymbols);

            // refresh the list and clear search
            Symbol_ListView.ItemsSource = stockSymbols;
            SearchBar.Text = string.Empty;

            // show completion 
            MessageBox.Show("Re-loaded new list");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close(); // close the project
        }
        #endregion




        #region Main View
        private void SearchSymbol_OnText(object sender, TextChangedEventArgs e)
        {
            string search = SearchBar.Text;

            // sort the list by searched symbol or company
            Symbol_ListView.ItemsSource = stockSymbols.Where(s => s.Symbol.IndexOf($"{search.ToUpper()}", StringComparison.CurrentCultureIgnoreCase) != -1
                || s.Name.IndexOf($"{search.ToUpper()}", StringComparison.CurrentCultureIgnoreCase) != -1)
                    .ToList();
        }
        #endregion
    }
}

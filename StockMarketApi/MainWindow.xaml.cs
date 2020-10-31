using StockMarketApi_WebApi;
using System;
using System.Collections.Generic;
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

namespace StockMarketApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // display todays date
            TodayDate.Content = DateTime.Now.ToString("dd MMM yy");

            // Initialize the api client
            ApiHelper.InitializeClient();


        }

        // runs at startup
        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            await LoadCompanyList();
        }

        private async Task LoadCompanyList()
        {
            var polyStocks = await PolygonStockProcessor.LoadCompanyList();

        }

        // search bar for company list
        private void Search_TextChange(object sender, TextChangedEventArgs e)
        {

        }

    }
}

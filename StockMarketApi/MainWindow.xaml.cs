
using APIHelperLibrary;
using ServiceStack;
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
        }


        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            //TimeStampList.ItemsSource = StockHelper.GetStocks("MSFT").Take(1);
        }

        private async void Search_TextChange(object sender, KeyEventArgs e)
        {

            List<SymbolModel> results;
            SearchComboBox.ItemsSource = null;

            if (!SearchComboBox.Text.IsNullOrEmpty())
            {
                results = await APIHelper.SearchSymbol(SearchComboBox.Text);

                SearchComboBox.ItemsSource = results;
            }
            else
            {
                SearchComboBox.Items.Clear();
            }
        }

        private void SearchComboBox_DropDownOpened(object sender, EventArgs e)
        {

        }
    }
}

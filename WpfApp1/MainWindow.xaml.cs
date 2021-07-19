using System.Linq;
using System.Windows;
using Nordea2;

namespace WpfApp1
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

        private async void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            var externalPriceService = new PriceExternalService();
            var priceService = new PriceService(externalPriceService);

            var prices = await priceService.GetPrices().ConfigureAwait(true);

            MessageBox.Show($"Downloaded {prices.Count()} prices.");

        }
    }
}

using System;
using System.Threading.Tasks;

namespace Nordea2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var externalPriceService = new PriceExternalService();
            var priceService = new PriceService(externalPriceService);

            var prices = await priceService.GetPrices();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price.Value} - {price.Date}");
            }
        }
    }
}

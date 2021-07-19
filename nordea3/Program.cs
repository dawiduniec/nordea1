using System;
using Nordea3.InterpolatedPrices;
using Nordea3.PriceDataSource;

namespace Nordea3
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpolatedPricesAlgorithm = new InterpolatedAlgorithmFactory();

            var priceManager = new PriceManager(new DummyPriceDataSource(), interpolatedPricesAlgorithm)
            {
                InterpolatedAlgorithm = InterpolatedAlgorithm.InterpolatedAlgorithm1
            };

            var result = priceManager.GetPrices();

            foreach (var price in result)
            {
                Console.WriteLine($"{price.ProductKey} - {price.Date} - {price.Value}");
            }
        }
    }
}

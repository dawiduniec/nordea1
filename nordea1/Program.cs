using System;
using System.Diagnostics;
using nordea1.Helpers;

namespace nordea1
{
    class Program
    {

        static void Main(string[] args)
        {

            var data = TestDataHelper.GenerateTestData(100000, 1000);
            data.Prices.Sort();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var dataPosition in data.Positions)
            {
                var pk = new Price
                {
                    ProductKey = dataPosition.ProductKey,
                    Date = dataPosition.Date
                };

                var priceLocation = data.Prices.BinarySearch(pk);
                if (priceLocation < 0)
                {
                    Console.WriteLine("Cant find price");
                    continue;
                }

                var price = data.Prices[priceLocation];

                if (price == null)
                {
                    Console.WriteLine($"Can't find price for product key: {dataPosition.ProductKey}");
                    continue;
                }

                Console.WriteLine($"Position market value: {(decimal) price.Value * dataPosition.Amount}");
            }

            Console.WriteLine($"Total time: {stopwatch.Elapsed.TotalSeconds}");
        }
    }
}

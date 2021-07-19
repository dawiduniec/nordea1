using System;
using System.Diagnostics;
using System.Linq;
using nordea1.Helpers;

namespace nordea1
{
    class Program
    {

        static void Main(string[] args)
        {

            var data = TestDataHelper.GenerateTestData(100000, 1000);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var dataPosition in data.Positions)
            {
                var price = data.Prices.FirstOrDefault(x => x.ProductKey == dataPosition.ProductKey);
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

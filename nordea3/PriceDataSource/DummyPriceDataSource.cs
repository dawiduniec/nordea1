using System;
using Nordea3.Models;

namespace Nordea3.PriceDataSource
{
    public class DummyPriceDataSource : IPriceDataSource
    {
        public Price[] GetPrices()
        {
            return new[]
            {
                new Price
                {
                    Date = DateTime.Now,
                    ProductKey = Guid.NewGuid().ToString(),
                    Value = 1
                },
                new Price
                {
                    Date = DateTime.Now,
                    ProductKey = Guid.NewGuid().ToString(),
                    Value = 1
                },
            };
        }
    }
}
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;

namespace Nordea2
{
    public class PriceExternalService
    {
        private static readonly Random Random = new Random();
        private static readonly Fixture Fixture = new Fixture();

        private static Price[] GenerateRandomPriceData()
        {
            return Fixture.CreateMany<Price>(Random.Next(5, 20)).ToArray();
        }

        public Task<Price[]> GetPricesFromWebService1()
        {
            var result = GenerateRandomPriceData();
            return Task.FromResult(result);
        }
        public Task<Price[]> GetPricesFromWebService2()
        {
            var result = GenerateRandomPriceData();
            return Task.FromResult(result);
        }

        public Task<Price[]> GetPricesFromWebService3()
        {
            var result = GenerateRandomPriceData();
            return Task.FromResult(result);
        }
    }
}

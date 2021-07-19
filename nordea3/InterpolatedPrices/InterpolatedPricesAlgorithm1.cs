using Nordea3.Models;

namespace Nordea3.InterpolatedPrices
{
    public class InterpolatedPricesAlgorithm1 : IInterpolatedsPricesAlgorithm
    {
        public Price[] GetInterpolatedPrices(Price[] pricesFromSource)
        {
            foreach (var price in pricesFromSource)
            {
                price.Value *= 1.2;
            }

            return pricesFromSource;
        }
    }
}
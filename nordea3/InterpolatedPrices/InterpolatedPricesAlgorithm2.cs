using Nordea3.Models;

namespace Nordea3.InterpolatedPrices
{
    public class InterpolatedPricesAlgorithm2 : IInterpolatedsPricesAlgorithm
    {
        public Price[] GetInterpolatedPrices(Price[] pricesFromSource)
        {
            foreach (var price in pricesFromSource)
            {
                price.Value *= 1.3;
            }

            return pricesFromSource;
        }
    }
}
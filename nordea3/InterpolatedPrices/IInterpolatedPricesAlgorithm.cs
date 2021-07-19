using Nordea3.Models;

namespace Nordea3.InterpolatedPrices
{
    public interface IInterpolatedsPricesAlgorithm
    {
        Price[] GetInterpolatedPrices(Price[] pricesFromSource);
    }
}
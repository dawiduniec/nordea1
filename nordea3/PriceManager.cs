using Nordea3.InterpolatedPrices;
using Nordea3.Models;
using Nordea3.PriceDataSource;

namespace Nordea3
{
    public class PriceManager
    {
        private readonly IPriceDataSource _priceDataSource;
        private readonly IInterpolatedAlgorithmFactory _interpolatedPricesFactory;
        
        public InterpolatedAlgorithm InterpolatedAlgorithm { get; set; }

        public PriceManager(IPriceDataSource priceDataSource, IInterpolatedAlgorithmFactory interpolatedPricesFactory)

        {
            _priceDataSource = priceDataSource;
            _interpolatedPricesFactory = interpolatedPricesFactory;
            InterpolatedAlgorithm = InterpolatedAlgorithm.InterpolatedAlgorithm1;
        }

        public Price[] GetPrices()
        {
            var dataSourcePrices = _priceDataSource.GetPrices();

            var interpolatedPricesAlgorithm = _interpolatedPricesFactory.GetInterpolatedAlgorithm(InterpolatedAlgorithm);

            var result = interpolatedPricesAlgorithm.GetInterpolatedPrices(dataSourcePrices);

            return result;
        }
    }
}
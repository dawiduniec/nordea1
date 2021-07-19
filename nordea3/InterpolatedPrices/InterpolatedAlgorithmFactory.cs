using System;

namespace Nordea3.InterpolatedPrices
{
    public class InterpolatedAlgorithmFactory : IInterpolatedAlgorithmFactory
    {
        public IInterpolatedsPricesAlgorithm GetInterpolatedAlgorithm(InterpolatedAlgorithm algorithm)
        {
            switch (algorithm)
            {
                case InterpolatedAlgorithm.InterpolatedAlgorithm1:
                    return new InterpolatedPricesAlgorithm1();
                case InterpolatedAlgorithm.InterpolatedAlgorithm2:
                    return new InterpolatedPricesAlgorithm2();
                default:
                    throw new ArgumentOutOfRangeException(nameof(algorithm), algorithm, null);
            }
        }
    }
}
namespace Nordea3.InterpolatedPrices
{
    public interface IInterpolatedAlgorithmFactory
    {
        IInterpolatedsPricesAlgorithm GetInterpolatedAlgorithm(InterpolatedAlgorithm algorithm);
    }
}

using Nordea3.Models;

namespace Nordea3.PriceDataSource
{
    public interface IPriceDataSource
    {
        Price[] GetPrices();
    }
}
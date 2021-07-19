using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nordea2
{
    public class PriceService
    {
        private readonly PriceExternalService _externalService;
        public PriceService(PriceExternalService externalService)
        {
            _externalService = externalService;
        }
        public async Task<IEnumerable<Price>> GetPrices()
        {
            var service1ResultTask = _externalService.GetPricesFromWebService1().ConfigureAwait(false);
            var service2ResultTask = _externalService.GetPricesFromWebService2().ConfigureAwait(false);
            var service3ResultTask = _externalService.GetPricesFromWebService3().ConfigureAwait(false);

            var prices1 = await service1ResultTask;
            var prices2 = await service2ResultTask;
            var prices3 = await service3ResultTask;

            var result = prices1.Union(prices2).Union(prices3);

            return result;
        }
    }
}

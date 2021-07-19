using System;
using System.Linq;
using AutoFixture;

namespace nordea1.Helpers
{
    public static class TestDataHelper
    {
        public static PositionsPrices GenerateTestData(int priceCount, int positionCount)
        {
            var fixture = new Fixture();

            var result = new PositionsPrices
            {
                Positions = fixture
                    .CreateMany<Position>(positionCount)
                    .ToArray(),
                Prices = fixture.CreateMany<Price>(priceCount).ToArray()
            };

            CreateProductKeyRelation(positionCount, priceCount, result);

            return result;
        }

        private static void CreateProductKeyRelation(int positionCount, int priceCount, PositionsPrices result)
        {
            var randomPrices = GetRandomPriceIndex(positionCount, priceCount);

            for (var i = 0; i < positionCount; i++)
            {
                result.Prices[randomPrices[i]].ProductKey = result.Positions[i].ProductKey;
            }
        }


        private static int[] GetRandomPriceIndex(int positionCount, int priceCount)
        {
            var random = new Random();
            var randomList = new int[positionCount];

            for (int i = 0; i < positionCount; i++)
            {
                int value;

                while (true)
                {
                    value = random.Next(0, priceCount);
                    if (randomList.Contains(value))
                    {
                        continue;
                    }

                    break;
                }

                randomList[i] = value;
            }

            return randomList;
        }
    }
}

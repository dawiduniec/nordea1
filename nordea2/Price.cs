using System;

namespace Nordea2
{
    public class Price : IEquatable<Price>
    {
        public DateTime Date { get; set; }
        public string ProductKey { get; set; }
        public double Value { get; set; }

        public bool Equals(Price other)
        {
            return other != null && ProductKey.Equals(other.ProductKey) && Date.Equals(other.Date);

        }

        public override int GetHashCode()
        {
            return (ProductKey == null ? 0 : ProductKey.GetHashCode()) ^ (Date == null ? 0 : Date.GetHashCode());
        }
    }
}
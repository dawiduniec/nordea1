using System;

namespace nordea1
{
    public class Price: IComparable<Price>
    {
        public DateTime Date { get; set; }
        public string ProductKey { get; set; }
        public double Value { get; set; }

        public int CompareTo(Price other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var dateComparison = Date.CompareTo(other.Date);
            if (dateComparison != 0) return dateComparison;
            return string.Compare(ProductKey, other.ProductKey, StringComparison.Ordinal);
        }
    }
}
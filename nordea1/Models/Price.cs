using System;

namespace nordea1
{
    public class Price
    {
        public DateTime Date { get; set; }
        public string ProductKey { get; set; }
        public double Value { get; set; }
    }
}
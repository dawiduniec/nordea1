using System;

namespace nordea1
{
    public class Position
    {
        public int PositionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string ProductKey { get; set; }
    }
}
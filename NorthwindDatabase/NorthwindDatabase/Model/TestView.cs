using System;
using System.Collections.Generic;

namespace NorthwindDatabase.Model
{
    public partial class TestView
    {
        public string? CustomerId { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal? CustomerValue { get; set; }
        public long? CustRank { get; set; }
        public long? OverallRank { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? PercentValue { get; set; }
    }
}

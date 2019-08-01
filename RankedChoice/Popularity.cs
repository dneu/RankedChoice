using System;
using System.Collections.Generic;
using System.Text;

namespace RankedChoice
{
    public class Popularity
    {
        private static Random randy = new Random();

        public double Baseline { get; set; }
        public double PercentageSupporters { get; set; }
        public double PopularityUpside { get; set; }
        public double PopularityDownside { get; set; }

        public double CalculatePopularity()
        {
            var affiliation = randy.NextDouble();
            var popularityBoost = affiliation <= PercentageSupporters ? PopularityUpside : -1 * PopularityDownside;
            return Baseline + popularityBoost + randy.NextDouble() / 10;
        }

    }
}

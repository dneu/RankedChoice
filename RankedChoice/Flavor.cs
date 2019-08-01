using System;
using System.Collections.Generic;
using System.Text;

namespace RankedChoice
{
    public class Flavor
    {
        public string Name { get; set; }
        public Popularity Popularity { get; set; } = new Popularity();

        public Flavor() { }

        public Flavor(string name, double baselinePop, double percSupporters, double popUpside, double popDownside)
        {
            Name = name;
            Popularity.Baseline = baselinePop;
            Popularity.PercentageSupporters = percSupporters;
            Popularity.PopularityUpside = popUpside;
            Popularity.PopularityDownside = popDownside;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace RankedChoice
{
    public class AllFlavors
    {
        public static List<Flavor> Flavors { get; set; } = new List<Flavor>()
        {
            new Flavor()
            {
                Name = "Chocolate",
                Popularity= new Popularity()
                {
                    PercentageSupporters=0.5,
                    PopularityUpside = 0.8,
                    PopularityDownside = 0.8
                }
            },
            new Flavor()
            {
                Name = "Vanilla",
                Popularity= new Popularity()
                {
                    Baseline=0.45,
                    PercentageSupporters=0.3,
                    PopularityUpside = 0.2,
                    PopularityDownside = 0.5
                }
            },
            new Flavor()
            {
                Name = "RockyRoad",
                Popularity= new Popularity()
                {
                    Baseline=0.4,
                    PercentageSupporters=0.2,
                    PopularityUpside = 0.9,
                    PopularityDownside = 0.2
                }
            },
            new Flavor()
            {
                Name = "Neopolitan",
                Popularity= new Popularity()
                {
                    Baseline=0.3,
                    PercentageSupporters=0.4,
                    PopularityUpside = 0.2,
                    PopularityDownside = 0.2
                }
            },
            new Flavor()
            {
                Name = "Strawberry",
                Popularity= new Popularity()
                {
                    Baseline=0.2,
                    PercentageSupporters=0.4,
                    PopularityUpside = 0.2,
                    PopularityDownside = 0.2
                }
            },
            new Flavor()
            {
                Name = "Oreo",
                Popularity= new Popularity()
                {
                    Baseline=0.1,
                    PercentageSupporters=0.4,
                    PopularityUpside = 0.2,
                    PopularityDownside = 0.2
                }
            }
        };
    }
}

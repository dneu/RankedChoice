using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RankedChoice
{
    public class BallotGenerator
    {
        public List<string[]> Generate(int numVoters)
        {
            var ballots = new List<string[]>(numVoters);

            for (int vtrNum = 0; vtrNum < numVoters; vtrNum++)
            {
                var favList = new List<Favorability>(AllFlavors.Flavors.Count);

                foreach(var flavor in AllFlavors.Flavors)
                {
                    var prob = flavor.Popularity.CalculatePopularity();
                    favList.Add(new Favorability() { Name = flavor.Name, Score = prob });
                    //Console.WriteLine($"{flavor.Name}: {(int)(prob*100)}");   
                }
                var choices = favList.OrderByDescending(f => f.Score).Select(f => f.Name).ToArray();

                ballots.Add(choices);
            }

            return ballots;
        }
    }

    public class Favorability
    {
        public string Name { get; set; }
        public double Score { get; set; }
    }
}

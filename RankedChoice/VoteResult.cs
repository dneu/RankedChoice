using System;
using System.Collections.Generic;
using System.Text;

namespace RankedChoice
{
    public class VoteResult
    {
        public string Name { get; set; }
        public int NumVotes { get; set; }
        public double VotePercentage { get; set; }

        public override string ToString()
        {
            return $"{Name}, {NumVotes}, {VotePercentage}";
        }
    }
}

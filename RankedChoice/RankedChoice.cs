using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StringTable;

namespace RankedChoice
{
    class RankedChoice
    {
        private int numVoters = 1000;

        private List<string[]> ballots;
        private HashSet<string> losers;
        
        public void Run(){

            ballots = new BallotGenerator().Generate(numVoters);
            losers = new HashSet<string>();

            for(int round=1; true; round++) { 

                var votes = TabulateVotes();

                DisplayVotes(votes, round);

                var winner = votes.FirstOrDefault(v => v.VotePercentage > 0.5);
                if(winner==null){
                    var loser = votes.OrderBy(v => v.NumVotes).First().Name;
                    Console.WriteLine($"No clear winner! Eliminating {loser}.");
                    Console.ReadKey();
                    losers.Add(loser);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"{winner.Name} wins!");
                    Console.ReadKey();
                    return;
                }
            }
        }
        
        private void DisplayVotes(IEnumerable<VoteResult> results, int roundNumber)
        {
            Console.WriteLine($"Voting round {roundNumber}");
            Console.WriteLine($"==============================================");
            Console.WriteLine($"Flavor       |    Num votes   |  Percentage votes");
            foreach(var res in results)
            {
                Console.Write(" " + res.Name.PadRight(12) + "|");
                Console.Write(" " + res.NumVotes.ToString().PadRight(15) + "|");
                Console.Write(" " + res.VotePercentage.ToString().PadRight(18));
                Console.WriteLine();
            }
        }

        private IEnumerable<VoteResult> TabulateVotes()
        {
            var votes = new Dictionary<string, int>();

            foreach (var ballot in ballots)
            {
                string myVote;
                int index = 0;
                do
                {
                    myVote = ballot[index];
                    index++;
                } while (losers.Contains(myVote));

                if (!votes.ContainsKey(myVote))
                {
                    votes.Add(myVote, 1);
                }
                else
                {
                    votes[myVote]++;
                }
            }

            return votes.OrderByDescending(v=>v.Value).Select(v=>new VoteResult{ Name=v.Key, NumVotes=v.Value, VotePercentage = (double)v.Value/numVoters });
        }
    }
}

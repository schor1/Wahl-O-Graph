using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Entities;

namespace Business
{
    static class Calculations
    {
        public static int CalculateConnectionScore(IEnumerable<Answer> answersParty1, List<Answer> answersParty2)
        {
            int score = 0;

            foreach (var party1Answer in answersParty1)
            {
                Answer party2Answer = answersParty2.Find(d => d.QuestionId == party1Answer.QuestionId);

                if (party1Answer.OptionId == party2Answer.OptionId)
                {
                    // Exact Match + 2
                    score += 2;
                }
                else if (party1Answer.OptionId == 3 || party2Answer.OptionId == 3)
                {
                    // One Party neutral + 1
                    score += 1;
                }
                // else + 0
            }

            return score;
        }

        public static Party SetConnectionScores(this Party self, List<Party> parties)
        {
            // initialize ConnectionScores
            self.ConnectionScores = new List<ConnectionScore>();
            
            // Create new List without itself, if included
            List<Party> partiesWithoutSelf = parties.Where(d => d.Id != self.Id).ToList();
            foreach (var party in partiesWithoutSelf)
            {
                int score = -1;
                if (party.Answers.Count > 0)
                    score = CalculateConnectionScore(self.Answers, party.Answers);

                self.ConnectionScores.Add(new ConnectionScore()
                {
                    Party = party,
                    Score = score
                });
            }

            return self;
        }
    }
}

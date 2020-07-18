using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Entities;
using Data;

namespace Business
{
    public class PartyController
    {
        private PartyRepository partyRepos;

        public PartyController()
        {
            partyRepos = new PartyRepository();
        }

        public List<Party> GetParties()
        {
            List<Party> retList = new List<Party>();

            // List of all Parties with their answers to iterate....
            List<Party> iterateList = partyRepos.GetParties().Select(Mapping.PartyDbToContract).ToList();
            // ... and to calculate the connection score
            List<Party> calcList = partyRepos.GetParties().Select(Mapping.PartyDbToContract).ToList();
            foreach (var party in iterateList)
            {
                retList.Add(party.SetConnectionScores(calcList));
            }

            return retList;
        }

        public List<Party> GetPartiesFilter(int? id, string nameShort, string nameLong)
        {
            return partyRepos.GetPartiesFilter(id, nameShort, nameLong).
                Select(Mapping.PartyDbToContract).ToList();
        }

        public void AddParty(Party newParty)
        {
            partyRepos.AddParty(Mapping.PartyContractToDb(newParty));
        }
    }
}


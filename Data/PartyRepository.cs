using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbParty = Data.PARTY;

namespace Data
{
    public class PartyRepository
    {
        public ICollection<DbParty> GetParties()
        {
            ICollection<DbParty> retList = new Collection<DbParty>();
            using (var ctx = new ElectionSqliteContext())
            {
                // since the context gets disposed, before the navigation attributes are queried,
                // all elements have to be added manually at this point, hence this stupid function..
                retList = getParties(ctx.PARTies.ToList());
            }

            return retList;
        }

        public List<DbParty> GetPartiesFilter(int? id, string nameShort, string nameLong)
        {
            using (var ctx = new ElectionSqliteContext())
            {
                return ctx.PARTies.Where(d => (d.ID == id || id == null) &&
                                                                  (d.NAME_SHORT == nameShort || 
                                                                   string.IsNullOrEmpty(nameShort)) &&
                                                                  (d.NAME_LONG == nameLong || 
                                                                   string.IsNullOrEmpty(nameLong))).ToList();
            }
        }

        public void AddParty(PARTY newParty)
        {
            using(var ctx = new ElectionSqliteContext())
            {
                ctx.PARTies.Add(newParty);
                ctx.SaveChanges();
            }
        }

        private ICollection<DbParty> getParties(IEnumerable<DbParty> parties)
        {
            Collection<DbParty> retList = new Collection<DbParty>();

            foreach (var party in parties)
            {
                var partyNew = party;

                partyNew.ANSWERs = getAnswers(party);
                retList.Add(partyNew);
            }

            return retList;
        }

        private ICollection<ANSWER> getAnswers(PARTY party)
        {
            List<ANSWER> retList = new List<ANSWER>();
            foreach (var wahlAnswer in party.ANSWERs)
            {
                retList.Add(new ANSWER()
                {
                    ID = wahlAnswer.ID,
                    PARTY = wahlAnswer.PARTY,
                    QUESTION = wahlAnswer.QUESTION,
                    QUESTIONnav = wahlAnswer.QUESTIONnav,
                    OPTION = wahlAnswer.OPTION,
                    OPTIONnav = wahlAnswer.OPTIONnav
                });
            }

            return retList;
        }
    }
}

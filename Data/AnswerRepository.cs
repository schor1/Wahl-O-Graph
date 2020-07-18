using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Entities;

namespace Data
{
    class AnswerRepository
    {
        public List<ANSWER> GetAnswersForParty(int partyId)
        {
            using (ElectionSqliteContext ctx = new ElectionSqliteContext())
            {
                return ctx.ANSWERs.Where(d => d.PARTY == partyId).ToList();
            }
        }
    }
}

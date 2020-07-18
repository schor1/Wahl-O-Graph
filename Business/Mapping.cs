using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Entities;
using DbParty = Data.PARTY;
using DbAnswer = Data.ANSWER;

namespace Business
{
    public static class Mapping
    {
        public static DbParty PartyContractToDb(Party party)
        {
            return new DbParty()
            {
                ID = (long)party.Id,
                NAME_LONG = party.NameLong,
                NAME_SHORT = party.NameShort
            };
        }

        public static Party PartyDbToContract(DbParty party)
        {
            return new Party()
            {
                Id = (decimal)party.ID,
                NameShort = party.NAME_SHORT,
                NameLong = party.NAME_LONG,
                Answers = party.ANSWERs.Select(AnswerDbToContract).ToList()
            };
        }

        public static Answer AnswerDbToContract(DbAnswer answer)
        {
            return new Answer()
            {
                Id = (int) answer.ID,
                QuestionId = (int) answer.QUESTION,
                QuestionText = answer.QUESTIONnav.TEXT,
                OptionId = (int) answer.OPTION,
                OptionText = answer.OPTIONnav.TEXT
            };
        }
    }
}

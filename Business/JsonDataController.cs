using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Entities.Json;
using Data;
using Answer = Contracts.Entities.Json.Answer;

namespace Business
{
    public class JsonDataController
    {
        public static List<Answer> getAnswers()
        {
            List<Answer> retList = new List<Answer>();
            foreach (var wahlAnswer in DataForJsonExportRepository.getAnswers())
            {
                retList.Add(new Answer()
                {
                    Id = (int)wahlAnswer.ID,
                    Option = (int)wahlAnswer.ANSWER,
                    Party = (int)wahlAnswer.PARTY,
                    Question = (int)wahlAnswer.QUESTION
                });
            }

            return retList;
        }

        public static List<Election> getElections()
        {
            List<Election> retList = new List<Election>();
            foreach (var wahlElection in DataForJsonExportRepository.getElections())
            {
                retList.Add(new Election()
                {
                    Id = (int)wahlElection.ID,
                    Year =  (int)wahlElection.YEAR,
                    Name = wahlElection.NAME
                });
            }

            return retList;
        }

        public static List<Option> getOptions()
        {
            List<Option> retList = new List<Option>();
            foreach (var wahlOption in DataForJsonExportRepository.getOptions())
            {
                retList.Add(new Option()
                {
                    Id = (int)wahlOption.ID,
                    Text = wahlOption.TEXT
                });
            }

            return retList;
        }

        public static List<Party> getParties()
        {
            List<Party> retList = new List<Party>();
            foreach (var wahlParty in DataForJsonExportRepository.getParties())
            {
                retList.Add(new Party()
                {
                    Id = (int)wahlParty.ID,
                    NameShort = wahlParty.NAME_SHORT,
                    NameLong = wahlParty.NAME_LONG
                });
            }

            return retList;
        }

        public static List<Question> getQuestions()
        {
            List<Question> retList = new List<Question>();
            foreach (var wahlQuestion in DataForJsonExportRepository.getQuestions())
            {
                retList.Add(new Question()
                {
                    Id = (int)wahlQuestion.ID,
                    Election = (int)wahlQuestion.ELECTION,
                    Text = wahlQuestion.TEXT
                });
            }

            return retList;
        }
    }
}

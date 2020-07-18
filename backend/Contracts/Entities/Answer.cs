using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int OptionId { get; set; }
        public string OptionText { get; set; }
    }
}

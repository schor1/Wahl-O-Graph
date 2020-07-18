using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
    public class Party
    {
        public virtual decimal Id
        {
            get;
            set;
        }

        public virtual string NameShort
        {
            get;
            set;
        }

        public virtual string NameLong
        {
            get;
            set;
        }

        public List<Answer> Answers { get; set; }

        public List<ConnectionScore> ConnectionScores { get; set; }

    }
}

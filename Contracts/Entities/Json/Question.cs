using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities.Json
{
    public class Question
    {
        public int Id { get; set; }

        public int Election { get; set; }

        public string Text { get; set; }
    }
}

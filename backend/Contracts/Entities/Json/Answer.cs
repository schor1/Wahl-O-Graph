using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities.Json
{
    public class Answer
    {
        public int Id { get; set; }
        public int Party { get; set; }
        public int Question { get; set; }
        public int Option { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities.Json
{
    public class Election
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
    }
}

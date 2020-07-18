using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities.Json
{
    public class Party
    {
        //{ ""id"":0, ""name"":""SPD"", ""longname"":""Sozialdemokratische Partei Deutschlands""},


        public int id { get; set; }

        public string name { get; set; }

        public string longname { get; set; }
    }
}

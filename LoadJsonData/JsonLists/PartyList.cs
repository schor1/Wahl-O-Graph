using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Entities.Json;
using Newtonsoft.Json;

namespace LoadJsonData.JsonLists
{
    public class PartyList
    {
        [JsonProperty(PropertyName = "parties")]
        List<Party> parties { get; set;  }

        public List<Party> getParties()
        {
            return parties;
        }
    }
}

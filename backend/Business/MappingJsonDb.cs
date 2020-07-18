using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonEntitie = Contracts.Entities.Json;

namespace Business
{
    class MappingJsonDb
    {
        public Data.PARTY JsonToDb(JsonEntitie.Party JsonParty)
        {
            return new Data.PARTY
            {
                NAME_LONG = JsonParty.longname,
                NAME_SHORT = JsonParty.name
            };
        }
    }
}

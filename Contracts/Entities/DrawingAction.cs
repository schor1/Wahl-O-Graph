using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
    public class DrawingAction
    {
        public string PartyName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public DrawingAction(string partyName, int x, int y)
        {
            PartyName = partyName;
            X = x;
            Y = y;
        }
    }
}

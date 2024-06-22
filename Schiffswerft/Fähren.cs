using Schiffswert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffswerft
{
    internal class Fähren:Schiffe
    {
        public int pkws;

        Fähren(string Name, int Laenge, string Eigentuemer, string Status, int Pkws)
            : base(Name, Laenge, Eigentuemer, Status)
        {
            pkws = Pkws; 
        }
    }
}

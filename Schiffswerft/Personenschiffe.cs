using Schiffswert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffswerft
{
    internal class Personenschiffe : Schiffe
    {
        public int passagierzahl;

        public Personenschiffe(string Name, int Laenge, string Eigentuemer, string Status, int Passagierzahl)
            :base(Name, Laenge, Eigentuemer, Status)
        {
            passagierzahl = Passagierzahl;
        }


    }
}

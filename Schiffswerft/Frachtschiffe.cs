using Schiffswert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffswerft
{
    internal class Frachtschiffe : Schiffe
    {
        public int zuladung;
        public int personenschiffe;

        public Frachtschiffe(string Name, int Laenge, string Eigentuemer, string Status, int Zuladung, int Personenschiffe)
            :base(Name, Laenge, Eigentuemer, Status)
        {
            zuladung = Zuladung;
            personenschiffe = Personenschiffe;
        }
    }
}

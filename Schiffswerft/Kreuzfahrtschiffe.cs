using Schiffswert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schiffswerft
{
    internal class Kreuzfahrtschiffe : Schiffe
    {
        public int decks;

        public Kreuzfahrtschiffe(string Name, int Laenge, string Eigentuemer, string Status, int Decks)
            :base(Name, Laenge, Eigentuemer, Status)
        {
            decks = Decks;
        }
    }
}

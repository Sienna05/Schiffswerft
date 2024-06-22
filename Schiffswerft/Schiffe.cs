

namespace Schiffswert
{
    abstract class Schiffe
    {
        public string name { get; set; }
        public int laenge { get; set; }
        public string eigentuemer { get; set; }
        public string staus { get; set; }


        public Schiffe (string Name, int Laenge, string Eigentuemer, string Status)
        {
            name = Name;
            laenge = Laenge;
            eigentuemer = Eigentuemer;
            staus = Status;

        }
    }
}
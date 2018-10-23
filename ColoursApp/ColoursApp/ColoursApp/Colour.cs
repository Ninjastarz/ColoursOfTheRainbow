using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoursApp
{
    public class Colour
    {
        public string Name { get; set; }
        public string Hex { get; set; }
        public List<int> RGBA { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\t Hex: {Hex}\t RGBA: {RGBA[0]}, {RGBA[1]}, {RGBA[2]}, {RGBA[3]}.";
        }
    }

    public class RootObject
    {
        public List<Colour> Colours { get; set; }
    }
}

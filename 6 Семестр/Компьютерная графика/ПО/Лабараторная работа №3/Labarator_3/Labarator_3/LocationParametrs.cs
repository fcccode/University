using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_1
{
    public class LocationParametrs
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public int Size { get; private set; }

        public LocationParametrs(string x, string y , int size)
        {
            X = float.Parse(x);
            Y = float.Parse(y);
            Size = size; 
        }
    }
}

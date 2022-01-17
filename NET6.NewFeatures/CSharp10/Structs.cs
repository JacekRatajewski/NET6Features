using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.NewFeatures.CSharp10
{
    public readonly struct Coords
    {
        public Coords()
        {
            X = 0;
            Y = 0;
        }

        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }

        public override string ToString() => $"({X}, {Y})";
    }
}

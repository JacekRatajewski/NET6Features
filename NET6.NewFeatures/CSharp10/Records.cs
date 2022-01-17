using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.NewFeatures.CSharp10
{
    public record class NonMutablePointA(double X, double Y, double Z);

    public record struct MutablePointB(double X, double Y, double Z);

    public readonly record struct NonMutablePointC(double X, double Y, double Z);
}

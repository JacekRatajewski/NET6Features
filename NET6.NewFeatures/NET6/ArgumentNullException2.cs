using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace NET6.NewFeatures.NET6
{
    public class ArgumentNullException2
    {
        public static void ThrowIfNull([NotNull] object? argument, [CallerArgumentExpression("argument")] string? paramName = null)
        {
            throw new ArgumentNullException(paramName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd.Tests
{
    static class StringExtensions
    {
        public static bool CompareStringOrdinalIgnoreCase(this string original, string comparedTo)
        {
            return original.Equals(comparedTo, StringComparison.OrdinalIgnoreCase);
        }
    }
}

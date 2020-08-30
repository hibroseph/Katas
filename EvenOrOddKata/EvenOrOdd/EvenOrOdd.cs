using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenOrOdd
{
    public class EvenOrOdd
    {
        public string IsEvenOrOdd(IEnumerable<int> numbers)
        {
            if (numbers is null)
                throw new ArgumentNullException();

            return numbers.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}

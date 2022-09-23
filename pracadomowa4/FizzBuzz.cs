using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracadomowa4
{
    class FizzBuzz
    {
        public string CheckRemainder(int numInt)
        {

            if (numInt % 5 == 0 && numInt % 3 == 0)
                return "FizzBuzz";

            if (numInt % 3 == 0)
                return "Fizz";

            if (numInt % 5 == 0)
                return "Buzz";

            return numInt.ToString();
        }

    }
}

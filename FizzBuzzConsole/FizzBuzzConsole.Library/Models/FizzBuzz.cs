using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class FizzBuzz
    {
        public int RunFizzBuzz(int count, int fizz, int buzz)
        {
            int currCount = 0;
            if (count % fizz == 0
                && count % buzz == 0)
            {
                currCount = 1;
            }

            return currCount;
        }
    }
}

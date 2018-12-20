using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class Fizz
    {
        public int RunFizz(int count)
        {
            int currCount = 0;
            Console.WriteLine("What is Fizz?");
            int fizz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out fizz);
            if (correctInput)
            {
                if (count % fizz == 0)
                {
                    currCount = 1;
                }
            }
            else
            {
                Console.WriteLine("Whole numbers only.");
                RunFizz(count);
            }
            return currCount;
        }
    }
}

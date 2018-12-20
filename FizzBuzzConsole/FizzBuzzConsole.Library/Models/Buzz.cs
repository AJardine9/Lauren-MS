using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class Buzz
    {
        public int RunBuzz(int count)
        {
            int currCount = 0;
            Console.WriteLine("What is Buzz?");
            int buzz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out buzz);
            if (correctInput)
            {
                if (count % buzz == 0)
                {
                    currCount = 1;
                }
            }
            else
            {
                Console.WriteLine("Whole numbers only.");
                RunBuzz(count);
            }
            return currCount;
        }
    }
}

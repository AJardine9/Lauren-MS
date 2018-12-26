using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class FizzBuzz
    {
        public static int fizzBuzzCount { get; set; }

        public int SetFizzBuzz()
        {
            Console.WriteLine("How many FizzBuzz?");
            int fizzBuzz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out fizzBuzz);
            if (!correctInput || fizzBuzz == 0)
            {
                Console.WriteLine("Whole numbers only, and only numbers greater than 0.");
                SetFizzBuzz();
            }

            return fizzBuzz;
        }

        public int RunFizzBuzz(int count, int fizz, int buzz)
        {
            if (count % fizz == 0
                && count % buzz == 0)
            {
                fizzBuzzCount++;
            }

            return fizzBuzzCount;
        }
    }
}

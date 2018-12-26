using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class Fizz
    {
        public static int fizzCount { get; set; }

        public int SetFizz()
        {
            Console.WriteLine("What should Fizz be divided by?");
            int fizz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out fizz);
            if (!correctInput || fizz == 0)
            {
                Console.WriteLine("Whole numbers only, and only numbers greater than 0.");
                SetFizz();
            }

            return fizz;
        }

        public void RunFizz(int count, int fizz)
        {
            if (count % fizz == 0)
            {
                fizzCount++;
            }
        }
    }
}

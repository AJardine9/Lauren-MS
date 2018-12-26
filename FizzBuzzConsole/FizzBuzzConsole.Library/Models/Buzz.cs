using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class Buzz
    {
        public static int buzzCount { get; set; }

        public int SetBuzz()
        {
            Console.WriteLine("What should Buzz be divided by?");
            int buzz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out buzz);
            if(!correctInput || buzz == 0)
            {
                Console.WriteLine("Whole numbers only, and only numbers greater than 0.");
                SetBuzz();
            }

            return buzz;
        }

        public void RunBuzz(int count, int buzz)
        {
            if (count % buzz == 0)
            {
                buzzCount++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library
{
    public class Buzz
    {
        public delegate int SetBuzz();
        public delegate void RunBuzz(int count, int buzz);
        public static int buzzCount { get; set; }

        private void DoBuzz(SetBuzz setB, RunBuzz runB, int count, int buzz)
        {
            buzzCount = setB();
            runB(count, buzz);
        }

        public void CallBuzz()
        {
            DoBuzz(SBuzz(), RBuzz(), buzzCount, (buzz) => { buzz = SBuzz(); });
        }

        public int SBuzz()
        {
            Console.WriteLine("What should Buzz be divided by?");
            int buzz;
            bool correctInput = Int32.TryParse(Console.ReadLine(), out buzz);
            if(!correctInput || buzz == 0)
            {
                Console.WriteLine("Whole numbers only, and only numbers greater than 0.");
                SBuzz();
            }

            return buzz;
        }

        public void RBuzz(int count, int buzz)
        {
            if (count % buzz == 0)
            {
                buzzCount++;
            }
        }
    }
}

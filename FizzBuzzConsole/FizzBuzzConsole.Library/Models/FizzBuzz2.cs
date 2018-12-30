using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole.Library.Models
{
    class FizzBuzz2
    {
        public delegate void Equation(ref int count, int fizzMod, int buzzMod, ref int fizzCount, ref int buzzCount, ref int fizzBuzzCount);
        public delegate int UserInput();


        private void SetValue(string userPrompt, out int value)
        {
            value = 0;
        }

        private void RunCheck(int fizzMod, int buzzMod, int fizzBuzzAmt, out int fizzCount, out int buzzCount, ref int fizzBuzzCount)
        {
            int count = 0;
            fizzCount = 0;
            buzzCount = 0;

            while (fizzBuzzCount < fizzBuzzAmt)
            {
                if (count % fizzMod == 0
                    && count % buzzMod == 0)
                {
                    fizzCount++;
                    buzzCount++;
                    fizzBuzzCount++;
                }
                else if (count % fizzMod == 0)
                {
                    fizzCount++;
                }
                else if (count % buzzMod == 0)
                {
                    buzzCount++;
                }

                count++;
            }
        }
    }
}

using System;
using FizzBuzzConsole.Library;

namespace FizzBuzzConsole.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int currCount = 0;

            var Buzz = new Buzz();
            var Fizz = new Fizz();
            var FizzBuzz = new FizzBuzz();
                        
            int fizzAmt = Fizz.SetFizz();
            int buzzAmt = Buzz.SBuzz();
            int fizzBuzzAmt = FizzBuzz.SetFizzBuzz();

            while (FizzBuzz.fizzBuzzCount < fizzBuzzAmt)
            {
                Fizz.RunFizz(currCount, fizzAmt);
                Buzz.RBuzz(currCount, buzzAmt);
                FizzBuzz.RunFizzBuzz(currCount, fizzAmt, buzzAmt);

                currCount++;
            }

            Console.WriteLine("Fizz: " + Fizz.fizzCount);
            Console.WriteLine("Buzz: " + Buzz.buzzCount);
            Console.WriteLine("FizzBuzz: " + FizzBuzz.fizzBuzzCount);
        }
    }
}

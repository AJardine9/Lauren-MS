using System;
using FizzBuzzConsole.Library;

namespace FizzBuzzConsole.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var Buzz = new Buzz();
            var Fizz = new Fizz();
            var FizzBuzz = new FizzBuzz();
            int currCount = 0;

            int buzzCount = Buzz.RunBuzz(currCount);
            int fizzCount = Fizz.RunFizz(currCount);
            int fizzBuzzCount = FizzBuzz.RunFizzBuzz(currCount, fizzCount, buzzCount);
        }
    }
}

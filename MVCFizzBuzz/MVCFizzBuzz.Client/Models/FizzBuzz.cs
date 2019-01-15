using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFizzBuzz.Client.Models
{
    public class FizzBuzz
    {
        private int count = 0;
        public int fizz { get; set; }
        public int buzz { get; set; }
        public int fizzbuzzmax { get; set; }
        private int fizzbuzz = 0;

        public FizzBuzz()
        {
            fizz = 0;
            buzz = 0;
            fizzbuzzmax = 50;
        }

        public void RunFizz()
        {
            if (fizzbuzz >= fizzbuzzmax)
            {
                return;
            }
            else
            {
                Fizz();
                Buzz();
                FizzBuzzs();
                count++;
                RunFizz();
            }
        }

        private void Fizz()
        {
            if (count % 3 == 0)
            {
                fizz++;
            }
        }

        private void Buzz()
        {
            if (count % 5 == 0)
            {
                buzz++;
            }
        }

        private void FizzBuzzs()
        {
            if (count % 3 == 0
                && count % 5 == 0)
            {
                fizzbuzz++;
            }
        }
    }
}

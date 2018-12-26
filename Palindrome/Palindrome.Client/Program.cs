using System;
using Palindrome.Library.Models;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var Handler = new PalindromeHandling();

            Console.WriteLine(Handler.Handling(""));
        }
    }
}

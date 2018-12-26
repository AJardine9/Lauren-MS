using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library.Models
{
    public class PalindromeHandling
    {
        public string Handling(string input)
        {
            string response = "Error";
            string userInput;

            if (input != "")
            {
                userInput = input.ToLower();
            }
            else
            {
                Console.WriteLine("What do you want to test as a palindrome?");
                userInput = Console.ReadLine().ToLower();
            }

            char[] forward = userInput.ToCharArray();
            char[] backward = userInput.ToCharArray();
            Array.Reverse(backward);

            for (int i = 0; i < forward.Length; i++)
            {

                if (forward[i] != backward[i])
                {
                    response = "Input was not a palindrome.";
                    break;
                }
                else
                {
                    if (i == forward.Length - 1)
                    {
                        response = "Input was a palindrome.";
                    }
                }
            }
            
            return response;
        }
    }
}

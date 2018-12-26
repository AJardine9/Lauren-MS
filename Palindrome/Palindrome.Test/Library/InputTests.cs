using System;
using System.Collections.Generic;
using System.Text;
using Palindrome.Library.Models;
using Xunit;

namespace Palindrome.Test.Library
{
    public class InputTests
    {
        [Fact]
        public void Test_PalindromeResponse()
        {
            var sut = new PalindromeHandling();
            var actual = sut.Handling("asdfdsA");

            // How to test if user input stops it?
            Assert.IsType<string>(actual);
            Assert.DoesNotContain("Error", actual);
        }

        [Fact]
        public void Test_PalindromeFailedResponse()
        {
            var sut = new PalindromeHandling();
            var actual = sut.Handling("asdfds2A");

            // How to test if user input stops it?
            Assert.IsType<string>(actual);
            Assert.DoesNotContain("Error", actual);
        }
    }
}

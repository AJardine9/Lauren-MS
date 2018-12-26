using GenericConsole.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GenericConsole.Tests.Library
{
    public class EmployeeTests
    {
        [Fact] //attribute w/ additional functionality to method
        public void Test_PeepName()
        {
            // sut subject under test
            var sut = new Peep();
            // var expected;
            var actual = sut.Name;

            Assert.IsType<string>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_PeepTitle()
        {
            // sut subject under test
            var sut = new Peep();
            // var expected;
            sut.Title = "Title";
            var actual = sut.Title;

            Assert.IsType<string>(actual);
            Assert.NotNull(actual);
        }
    }
}

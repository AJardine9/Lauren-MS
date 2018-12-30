using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ParallelWorld.Domain.Models;

namespace ParallelWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Thread1()
        {
            var sut = new ThreadModel();
            var expected = "fred";
            var actual = sut.ThreadMaster(expected);

            Assert.True(expected == actual);
        }
    }
}

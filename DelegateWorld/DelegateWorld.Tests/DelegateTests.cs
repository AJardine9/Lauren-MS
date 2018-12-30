using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DelegateWorld.Domain.Models;

namespace DelegateWorld.Tests
{
    public class DelegateTests
    {
        [Fact]
        public void Delegate_Test()
        {

        }

        [Fact]
        public void Delegate_Sharpie2()
        {
            var expected = "lauren benson";
            var f = "lauren";
            var l = "benson";
            var sut = new ActionFunc();
            var actual = sut.Sharpie2(f, l);

            Assert.True(expected == actual);
        }

        [Fact]
        public void Delegate_Something()
        {
            var expected = "fred belotte";
        }
    }
}

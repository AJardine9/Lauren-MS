using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VarianceWorld.Domain.Models;
using Xunit;

namespace VarianceWorld.Tests.library
{
    public class CastingTest
    {
        [Fact]
        public void Test_Explicit()
        {
            IEnumerable<byte?> expected = new byte?[2];
            var x = (short)10;
            byte y = 10;
            byte? z = null;
            var sut = new Casting();
            var actual = sut.Explicit(x);

            //Assert.IsType<short>(x);
            //Assert.IsType<byte?>(actual);
            Assert.True(expected.Count() == actual.Count());
            Assert.True(y == actual.ElementAt(0));
            Assert.False(z == actual.ElementAt(1));
        }

        [Fact]
        public void Test_ExplicitOut()
        {
            var x = (short)10;
            byte y;
            byte? z;
            var sut = new Casting();
            sut.Explicit(x, out y, out z);

            //Assert.IsType<short>(x);
            //Assert.IsType<byte>(y);
            //Assert.IsType<byte?>(z);
            Assert.True(y == x);
            Assert.False(z == x);
        }
        [Fact]
        public void Test_ExplicitRef()
        {
            var expected = 100;
            var w = (short)10;
            var x = (short)10;
            byte y = 10;
            byte? z = null;

            var sut = new Casting();
            sut.Explicit(ref w, ref x, out y, out z);

            //Assert.IsType<short>(w);
            //Assert.IsType<short>(x);
            //Assert.IsType<byte>(y);
            //Assert.IsType<byte?>(z);
            Assert.Equal(expected, w);
            Assert.Equal(expected, x);
            Assert.False(z == w);
            Assert.True(y == w);
            Assert.True(w == x);
            Assert.True(x == expected);
        }

        [Fact]
        public void Test_ExplicitNoRef()
        {
            var expected = 100;
            var w = (short)10;
            var x = (short)10;
            var sut = new Casting();
            sut.Explicit(w, x);

            Assert.Equal(expected, w);
            Assert.Equal(expected, x);
        }
    }
}

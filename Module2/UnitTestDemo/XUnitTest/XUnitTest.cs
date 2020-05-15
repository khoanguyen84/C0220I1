using System;
using Xunit;
using UnitTestDemo;

namespace XUnitTest
{
    public class XUnitTest
    {
        private MyMath myMath;
        public XUnitTest()
        {
            myMath = new MyMath();
        }
        [Fact]
        public void SubtractTest_1()
        {
            Assert.Equal(5, myMath.Subtract(10, 5));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void SubtractTest_10(int value)
        {
            Assert.Equal(value, myMath.Subtract(value, 0));
            Assert.NotEqual(value, myMath.Subtract(value, 1));
        }
    }
}

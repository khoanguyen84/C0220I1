using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTest
{
    public class MyMathTest
    {
        private MyMath myMath;
        [SetUp]
        public void Setup()
        {
            myMath = new MyMath();
        }

        [Test]
        public void Additional_1()
        {
            Assert.AreEqual(10, myMath.Additional(4,6));
            Assert.AreNotEqual(10, myMath.Additional(6, 3));
            Assert.IsTrue(myMath.Additional(6, 4) == 10);
            Assert.AreNotSame(10, myMath.Additional(5, 5));
        }
        [TestCase(10)]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(50)]
        public void Additional_10(int value)
        {
            Assert.AreEqual(value, myMath.Additional(0, value));
            Assert.AreNotEqual(value, myMath.Additional(10, value - 9));
        }

        [Test]
        public void Additional_100()
        {
            Assert.GreaterOrEqual(myMath.Additional(5, 5), 0);
            Assert.LessOrEqual(myMath.Additional(5, 5), 10);
        }
    }
}

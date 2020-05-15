using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
namespace MSTest
{
    [TestClass]
    public class MSTestDemo
    {
        private MyMath myMath = new MyMath();
        [TestMethod]
        public void MultipleTest_1()
        {
            Assert.IsFalse(myMath.Multiple(1, 5) == 4);
        }

        [TestMethod]
        public void MultipleTest_10()
        {
            Assert.AreEqual(50, myMath.Multiple(5, 10));
        }
    }
}

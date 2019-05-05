using System;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMaxArea()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //Assert.AreEqual(49, LeetCodeProblem.Array._11_Container_With_Most_Water.MaxArea(height));
        }
        [Test]
        public void Test3Sum()
        {
            Assert.AreEqual(0, LeetCodeProblem.Array._15_3Sum.test());
        }

    }
}

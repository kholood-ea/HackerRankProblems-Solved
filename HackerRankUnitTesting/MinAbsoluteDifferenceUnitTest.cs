using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTesting
{
    [TestClass]
    public class MinAbsoluteDifferenceUnitTest
    {
        [TestMethod]
        public void minimumAbsoluteDifference_ShouldReturnZero()
        {
            int[] ar = {9,9,9,9,9 };
            int result = HackerRank.MinAbsoluteDifference.minimumAbsoluteDifference(ar);
            Assert.AreEqual(0, result);
        }
    }
}

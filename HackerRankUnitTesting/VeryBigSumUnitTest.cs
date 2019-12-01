using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTesting
{
    [TestClass]
    public class VeryBigSumUnitTest
    {
        [TestMethod]
        public void VeryBigSum_ShouldReturnVal()
        {
            //arrange
            //string[] foo = long.OfType<long>().Select(o => o.ToString()).ToArray();
            long[] ar = new long[3] { 1000, 2000, 3000 };
            //long[] ar = new long[3];
            //ar[0] = 1000;
            //ar[1] = 2000;
            //ar[2] = 3000;

            //Array ar = new[] { 1000, 2000, 3000};

            //act
            long result = HackerRank.VeryBigSum.aVeryBigSum(ar);
            //assert
            Assert.AreEqual(6000, result);
        }
    }
}

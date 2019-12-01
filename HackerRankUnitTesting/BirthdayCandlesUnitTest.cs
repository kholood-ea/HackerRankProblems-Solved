using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTesting
{
    [TestClass]
    public class BirthdayCandlesUnitTest
    {
        [TestMethod]
        public void birthdayCakeCandles_ShouldReturn1()
        {
                //arrrange
                int[] ar = new int[5] { 9, 5, 9, 2, 3 };
                //act
                int count = HackerRank.BirthdayCandles.birthdayCakeCandles(ar);
                //assert
                Assert.AreEqual(2, count);
            }

        [TestMethod]
        public void TestMethod2()
        {
            //arrrange
            int[] ar = new int[0] { };
            //act
            int count = HackerRank.BirthdayCandles.birthdayCakeCandles(ar);
            //assert
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrrange
            int[] ar = new int[1] { 1 };
            //act
            int count = HackerRank.BirthdayCandles.birthdayCakeCandles(ar);
            //assert
            Assert.AreEqual(1, count);
        }


    }
}

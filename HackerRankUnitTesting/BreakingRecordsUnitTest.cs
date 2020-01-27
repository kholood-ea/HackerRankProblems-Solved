using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTesting
{
    [TestClass]
    public class BreakingRecordsUnitTest
    {
        [TestMethod]
        public void BreakingRecordsReturnsNo0()
        {
            int[] arr = {50,60, 70,40 ,20,30,100,10,90,80 };
            int[] arr1 = HackerRank.BreakingRecords.breakingRecords(arr);
            int[] result = {3,3 };
            CollectionAssert.AreEqual(arr1,result);
        }
        [TestMethod]
        public void BreakingRecordsReturnsNo1()
        {
            int[] arr = { 0, 0, 0, 0, 0 };
            int[] arr1 = HackerRank.BreakingRecords.breakingRecords(arr);
            int[] result = { 0, 0 };
            CollectionAssert.AreEqual(arr1, result);
        }
    }
}

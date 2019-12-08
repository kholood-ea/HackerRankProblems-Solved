using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace HackerRankUnitTesting
{
    [TestClass]
    public class DiagonalDifferenceUnitTest
    {
        [TestMethod]
        public void DiagonalDifferenceUnitShouldReturnZero()

        {
            List<int> ar1 = new List<int>() {0,0,0 };
            List<int> ar2 = new List<int>() { 0, 0, 0 };
            List<int> ar3 = new List<int>() { 0, 0, 0 };
            List<List<int>> arr = new List<List<int>>() {ar1,ar2,ar3 };
            int result = HackerRank.DiagonalDifference.Result.diagonalDifference(arr);
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void DiagonalDifferenceUnitShouldReturnValue()

        {
            List<int> ar1 = new List<int>() { 1, 2, 3 };
            List<int> ar2 = new List<int>() { 4, 5, 6 };
            List<int> ar3 = new List<int>() { 7, 8, 9 };
            List<List<int>> arr = new List<List<int>>() { ar1, ar2, ar3 };
            int result = HackerRank.DiagonalDifference.Result.diagonalDifference(arr);
            Assert.AreEqual(0, result);

        }
    }
}

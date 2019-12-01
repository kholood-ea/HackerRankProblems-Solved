using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HackerRank;




namespace HackerRankUnitTesting
{
    [TestClass]
    public class ComparingTripletsUnitTest
    {
        [TestMethod]
        public void Equalitypositive()
        {
            //arrange
            List<int> a = new List<int>() {1,2,3 };
            List<int> b = new List<int>() {3,2,1 };


            //act
            List<int> result = new List<int>();
            List<int> result1 = new List<int>() {1,1};

            result = HackerRank.ComparingTriplets.compareTriplets(a, b);

            //assert
            //CollectionAssert.AreEquivalent
            CollectionAssert.AreEqual(result,result1);

        }
        [TestMethod]
        public void EqualityZero()
        {
            //arrange
            List<int> a = new List<int>() { 0, 0, 0 };
            List<int> b = new List<int>() { 0, 0, 0 };


            //act
            List<int> result = new List<int>();
            List<int> result1 = new List<int>() { 0, 0 };

            result = HackerRank.ComparingTriplets.compareTriplets(a, b);

            //assert
            //CollectionAssert.AreEquivalent
            CollectionAssert.AreEqual(result, result1);

        }
        public void Equalityminus()
        {
            //arrange
            List<int> a = new List<int>() { -1, -1, -3 };
            List<int> b = new List<int>() { -2, -1, -1 };


            //act
            List<int> result = new List<int>();
            List<int> result1 = new List<int>() { 1, 1 };

            result = HackerRank.ComparingTriplets.compareTriplets(a, b);

            //assert
            //CollectionAssert.AreEquivalent
            CollectionAssert.AreEqual(result, result1);

        }
        public void max()
        {
            //arrange
            List<int> a = new List<int>() { 100, 95, 80 };
            List<int> b = new List<int>() { 100, 100, 100 };


            //act
            List<int> result = new List<int>();
            List<int> result1 = new List<int>() { 1, 1 };

            result = HackerRank.ComparingTriplets.compareTriplets(a, b);

            //assert
            //CollectionAssert.AreEquivalent
            CollectionAssert.AreEqual(result, result1);

        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTesting
{
    [TestClass]
    public class GradingStudentsUnitTest
    {
        [TestMethod]
        public void GradingStudents_Should_Return_SameNumber()
        {
            List<int> a = new List<int>()
            { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,40,45,50,55,60,65,70,75,80,85,90,95,100 
            };

            List<int> k = HackerRank.GradingStudents.gradingStudents(a);
            CollectionAssert.AreEqual(a, k);
        }
        [TestMethod]
        public void GradingStudents_Should_Return_x5()
        {
            List<int> b = new List<int>()
            { 43,44,53,54,63,64,73,74,83,84,93,94};
            List<int> l = HackerRank.GradingStudents.gradingStudents(b);
            List<int> da = new List<int>() { 45,45,55,55,65,65,75,75,85,85,95,95 };
            CollectionAssert.AreEqual(da, l);
        }

        [TestMethod]
        public void GradingStudents_Should_Return_x0()
        {
            List<int> b = new List<int>()
            { 48,49,58,59,68,69,78,79,88,89,98,99};
            List<int> l = HackerRank.GradingStudents.gradingStudents(b);
            List<int> da = new List<int>() { 50, 50, 60, 60, 70, 70, 80, 80, 90, 90, 100, 100 };
            CollectionAssert.AreEqual(da, l);
        }


        [TestMethod]
        public void TestMethod1()
        {
            List<int> a = new List<int>() {0,1,2,3,4,5,6,7,8,9,10 };
            List<int> b = new List<int>() {11,12,13,14,15,16,17,18,19,20 };
            List<int> c = new List<int>() {21,22,23,24,25,26,27,28,29,30 };
            List<int> d = new List<int>() {31,32,33,34,35,36,37,38,39,40 };
            List<int> e = new List<int>() {41,42,43,44,45,46,47,48,49,50 };
            List<int> f = new List<int>() {51,52,53,54,55,56,57,58,59,60 };
            List<int> g = new List<int>() {61,62,63,64,65,66,67,68,69,70 };
            List<int> h = new List<int>() {71,72,73,74,75,76,77,78,79,80 };
            List<int> i = new List<int>() {81,82,83,84,85,86,87,88,89,90 };
            List<int> j = new List<int>() {91,92,93,94,95,96,97,98,99,100 };

            List<int> k = HackerRank.GradingStudents.gradingStudents(a);
            List<int> l = HackerRank.GradingStudents.gradingStudents(b);
            List<int> m = HackerRank.GradingStudents.gradingStudents(c);
            List<int> n = HackerRank.GradingStudents.gradingStudents(d);
            List<int> o = HackerRank.GradingStudents.gradingStudents(e);
            List<int> p = HackerRank.GradingStudents.gradingStudents(f);
            List<int> q = HackerRank.GradingStudents.gradingStudents(g);
            List<int> r = HackerRank.GradingStudents.gradingStudents(h);
            List<int> s = HackerRank.GradingStudents.gradingStudents(i);
            List<int> t = HackerRank.GradingStudents.gradingStudents(j);

            List<int> da = new List<int>() { 31, 32, 33, 34, 35, 36, 37, 40, 40, 40 };
            List<int> ea = new List<int>() { 41, 42, 45, 45, 45, 46, 47, 50, 50, 50 };
            List<int> fa = new List<int>() { 51, 52, 55, 55, 55, 56, 57, 60, 60, 60 };
            List<int> ga = new List<int>() { 61, 62, 65, 65, 65, 66, 67, 70, 70, 70 };
            List<int> ha = new List<int>() { 71, 72, 75, 75, 75, 76, 77, 80, 80, 80 };
            List<int> ia = new List<int>() { 81, 82, 85, 85, 85, 86, 87, 90, 90, 90 };
            List<int> ja = new List<int>() { 91, 92, 95, 95, 95, 96, 97, 100,100, 100 };
            CollectionAssert.AreEqual(a,k);
            CollectionAssert.AreEqual(b, l);
            CollectionAssert.AreEqual(c, m);
            CollectionAssert.AreEqual(n,da);
            CollectionAssert.AreEqual(o, ea);
            CollectionAssert.AreEqual(p, fa);
            CollectionAssert.AreEqual(q, ga);
            CollectionAssert.AreEqual(r, ha);
            CollectionAssert.AreEqual(s, ia);
            CollectionAssert.AreEqual(t, ja);





        }
    }
}

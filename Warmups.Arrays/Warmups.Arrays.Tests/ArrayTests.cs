using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Arrays.BLL;

namespace Warmups.Arrays.Tests
{
    [TestFixture]
    class ArrayTests
    {
        [TestCase(new[] { 1, 2, 6 }, true)]
        [TestCase(new[] { 6, 1, 2, 3 }, true)]
        [TestCase(new[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6(int [] numbers, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.FirstLast6(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, false)]
        [TestCase(new[] { 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 2, 1 }, true)]
        public void SameFirstLast(int[] numbers, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.SameFirstLast(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, new[] {3, 1, 4})]       
        public void MakePi(int n, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.MakePi(n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3 }, true)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3, 2 }, false)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 3 }, true)]

        public void CommonEnd(int[] a, int [] b, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.CommonEnd(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, 6)]
        [TestCase(new[] { 5, 11, 2 }, 18)]
        [TestCase(new[] { 7, 0, 0 }, 7)]      
        public void Sum(int[] a, int expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int actualResult = loops.Sum(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
        [TestCase(new[] { 5, 11, 9 }, new[] { 11, 9, 5 })]
        [TestCase(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        public void RotateLeft(int[] numbers, int [] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.RotateLeft(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 5, 11, 9 }, new[] { 9, 11, 5 })]
        [TestCase(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        public void Reverse(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.Reverse(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 3, 3 })]
        [TestCase(new[] { 11, 5, 9 }, new[] { 11, 11, 11 })]
        [TestCase(new[] { 2, 11, 3 }, new[] { 3, 3, 3 })]
        public void HigherWins(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.HigherWins(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new [] {1, 2, 3}, new [] {4, 5, 6}, new [] {2, 5})]
        [TestCase(new [] {7, 7, 7}, new [] {3, 8, 0}, new [] {7, 8})]
        [TestCase(new [] {5, 2, 9}, new [] {1, 4, 5}, new [] {2, 4})]
        public void GetMiddle(int[] a, int[] b, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.GetMiddle(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 2, 5 }, true)]
        [TestCase(new[] { 4, 3 }, true)]
        [TestCase(new[] { 7, 5 }, false)]
        public void HasEven(int[] numbers, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.HasEven(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 4, 5, 6 }, new[]{ 0, 0, 0, 0, 0, 6 })]
        [TestCase(new[] { 1, 2 }, new[] { 0, 0, 0, 2 })]
        [TestCase(new[] { 3 }, new[] { 0, 3 })]
        public void KeepLast(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.KeepLast(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 2, 2, 3 }, true)]
        [TestCase(new[] { 3, 4, 5, 3 }, true)]
        [TestCase(new[] { 2, 3, 2, 2 }, false)]
        public void Double23(int[] numbers, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.Double23(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 0 })]
        [TestCase(new[] { 2, 3, 5 }, new[] { 2, 0, 5 })]
        [TestCase(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
        public void Fix23(int[] numbers, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.Fix23(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 1, 1, 1 }, false)]
        public void Unlucky1(int[] numbers, bool expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            bool actualResult = loops.Unlucky1(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] {4, 5}, new[] {1, 2, 3}, new[] {4, 5})]
        [TestCase(new[] {4}, new[] {1, 2, 3}, new[] {4, 1})]
        [TestCase(new int[] {}, new[] {1, 2}, new[] {1, 2})]
        public void make2(int[] a, int[] b, int[] expectedResult)
        {
            ArrayWarmups loops = new ArrayWarmups();
            int[] actualResult = loops.make2(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }


}

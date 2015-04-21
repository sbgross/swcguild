using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Loops.BLL;

namespace Warmups.Loops.Tests
{
    [TestFixture]
    class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.StringTimes(str,n);

            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes(string str, int n, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.FrontTimes(str, n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX(string str, int expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            int actualResult = loops.CountXX(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleX(string str, bool expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            bool actualResult = loops.DoubleX(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo","Hello")]
        public void EveryOther(string str, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.EveryOther(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosion(string str, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.StringSplosion(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2(string str, int expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            int actualResult = loops.CountLast2(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 9 }, 1,TestName = "1")]
        [TestCase(new[] { 1, 9, 9 }, 2, TestName = "2")]
        [TestCase(new[] { 1, 9, 9, 3, 9 }, 3, TestName = "3")] 
        public void Count9(int[] numbers, int expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            int actualResult = loops.Count9(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 9, 3, 4 }, true, TestName = "1")]
        [TestCase(new[] { 1, 2, 3, 4, 9 }, false, TestName = "2")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, false, TestName = "3")]
        public void ArrayFront9(int[] numbers, bool expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            bool actualResult = loops.ArrayFront9(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 1, 2, 3, 1 }, true, TestName = "1")]
        [TestCase(new[] { 1, 1, 2, 4, 1 }, false, TestName = "2")]
        [TestCase(new[] { 1, 1, 2, 1, 2, 3 }, true, TestName = "3")]
        public void Array123(int[] numbers, bool expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            bool actualResult = loops.Array123(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubStringMatch(string a, string b, int expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            int actualResult = loops.SubStringMatch(a,b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX(string str, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.StringX(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs(string str, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.AltPairs(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak(string str, string expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            string actualResult = loops.DoNotYak(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 6, 6, 2 }, 1)]
        [TestCase(new[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new[] { 6, 7, 2, 6 }, 1)]
        public void Array667(int[] numbers, int expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            int actualResult = loops.Array667(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 1, 2, 7, 1 }, true)]
        [TestCase(new[] { 1, 2, 8, 1 }, false)]
        [TestCase(new[] { 2, 7, 1 }, true)]
        public void Pattern51(int[] numbers, bool expectedResult)
        {
            LoopWarmups loops = new LoopWarmups();
            bool actualResult = loops.Pattern51(numbers);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.Conditionals.BLL;

namespace Warmups.Conditionals.Tests
{
    [TestFixture]
    class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTrouble(bool aSmile, bool bSmile, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.AreWeInTrouble(aSmile, bSmile);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.CanSleepIn(isWeekday,isVacation);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            int actualResult = conditions.SumDouble(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            int actualResult = conditions.Diff21(n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool isTalking, int hour, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.ParrotTrouble(isTalking, hour);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.Makes10(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred(int n, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.NearHundred(n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNeg(int a, int b, bool negative, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.PosNeg(a,b,negative);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString(string s, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.NotString(s);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string str, int n, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.MissingChar(str, n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack(string str,string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.FrontBack(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3(string str, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.Front3(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround(string str, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.BackAround(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi(string str, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.StartHi(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot(int temp1, int temp2, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.IcyHot(temp1, temp2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20(int a, int b, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.Between10and20(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen(int a, int b, int c, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.HasTeen(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone(int a, int b, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.SoAlone(a, b);

        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello","aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel(string str, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.RemoveDel(str);

        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart(string str, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.IxStart(str);

        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz(string str, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.StartOz(str);

        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void Max(int a, int b, int c, int expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            int actualResult = conditions.Max(a, b, c);

        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void Closer(int a, int b, int expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            int actualResult = conditions.Closer(a, b);

        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE(string str, bool expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            bool actualResult = conditions.GotE(str);

        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp(string str, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.EndUp(str);

        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth(string str, int n, string expectedResult)
        {
            ConditionalWarmups conditions = new ConditionalWarmups();
            string actualResult = conditions.EveryNth(str, n);
        }
    }
}

using NUnit.Framework;
using Prime;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class TestCaseSource
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(int.MinValue, false);
                yield return new TestCaseData(-1, false);
                yield return new TestCaseData(0, false);
                yield return new TestCaseData(1, false);
                yield return new TestCaseData(2, true);
                yield return new TestCaseData(3, true);
                yield return new TestCaseData(4, true);
                yield return new TestCaseData(997, true);
                yield return new TestCaseData(int.MaxValue, true);
                yield return new TestCaseData(int.MaxValue-1, false);
            }
        }

        [TestCaseSource(nameof(TestCases))]
        public void TestThat_IsPrime_Returns_CorrectResult(int input, bool expected)
        {
            var prime = new PrimeTools();
            bool result = prime.IsPrime(input);
            Assert.AreEqual(expected, result);
        }
    }
}

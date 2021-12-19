using NUnit.Framework;
using Prime;

namespace Tests
{
    [TestFixture]
    public class PrimeTests
    {
        [TestCase(int.MinValue, false)]
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, true)]
        [TestCase(997, true)]
        [TestCase(int.MaxValue, true)]
        [TestCase(int.MaxValue-1, false)]
        public void TestThat_IsPrime_Returns_CorrectResult(int input, bool expected)
        {
            var prime = new PrimeTools();
            bool result = prime.IsPrime(input);
            Assert.AreEqual(expected, result);
        }
    }
}

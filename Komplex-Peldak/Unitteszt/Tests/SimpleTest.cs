using NUnit.Framework;
using Prime;

namespace Tests
{
    [TestFixture]
    public class PrimeSimple
    {
        private PrimeTools _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new PrimeTools();
        }

        [TearDown]
        public void Teardown()
        {
            _sut = null;
        }

        [Test]
        public void TestThat_0_IsnotPrime()
        {
            bool result = _sut.IsPrime(0);
            Assert.That(result, Is.False);
            Assert.IsFalse(result);
        }
    }
}

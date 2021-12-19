using MockExample;
using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    internal class MockTest
    {
        private Mock<INumberProvider> _numberProviderMock;
        private Mock<IConsole> _consoleMock;
        private NumberConsumer _sut;

        [SetUp]
        public void Setup()
        {
            _consoleMock = new Mock<IConsole>(MockBehavior.Strict);
            _numberProviderMock = new Mock<INumberProvider>(MockBehavior.Strict);
            _sut = new NumberConsumer(_numberProviderMock.Object, _consoleMock.Object);
        }

        [Test]
        public void Test_Initialize_Registers_WidthChange()
        {
            //arrange
            _consoleMock.SetupAdd(m => m.WidthChanged += It.IsAny<EventHandler<int>>());
            //act
            _sut.Initialize();
            //assert
            _consoleMock.VerifyAdd(m => m.WidthChanged += It.IsAny<EventHandler<int>>());
        }

        [Test]
        public void Test_DeInitialize_UnRegisters_WidthChange()
        {
            //arrange
            _consoleMock.SetupRemove(m => m.WidthChanged -= It.IsAny<EventHandler<int>>());
            //act
            _sut.Deinitialize();
            //assert
            _consoleMock.VerifyRemove(m => m.WidthChanged -= It.IsAny<EventHandler<int>>());
        }

        [Test]
        public void Test_DisplayNumber()
        {
            //arrange
            _consoleMock.SetupGet(m => m.Width).Returns(10);
            _consoleMock.Setup(m => m.WriteLine(It.IsAny<string>()));
            _numberProviderMock.Setup(m => m.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(4);
            //act
            _sut.Initialize();
            _consoleMock.Raise(m => m.WidthChanged += It.IsAny<EventHandler<int>>(), _consoleMock.Object, 10);
            _sut.DisplayNumber(1, 10);

            //assert
            _numberProviderMock.Verify(m => m.GetRandomNumber(It.Is<int>(x => x == 1), It.Is<int>(x => x == 10)), Times.);
            _consoleMock.Verify(m => m.WriteLine(It.Is<string>(x => x == "         4")), Times.Once);
        }
    }
}

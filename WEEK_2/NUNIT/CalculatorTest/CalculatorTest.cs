using NUnit.Framework;
using CalcLibrary; 

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 5, 5)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expected)
        {
            var result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("This test is ignored for demo")]
        public void IgnoredTest()
        {
            Assert.Fail("Should be skipped");
        }
    }
}

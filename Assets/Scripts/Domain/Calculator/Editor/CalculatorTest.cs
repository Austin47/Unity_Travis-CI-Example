using NUnit.Framework;

namespace Domain.CalculatorService.Test
{
    public class CalculatorTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, -4)]
        [TestCase(0, -2, -2)]
        [TestCase(0, 0, 0)]
        public void TestAdd(float v1, float v2, float expected)
        {
            // Act
            var actual = Calculator.Instance.Calculate(v1, v2, Operation.Add);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(-2, -2, 0)]
        [TestCase(0, -2, 2)]
        [TestCase(0, 0, 0)]
        public void TestSubtract(float v1, float v2, float expected)
        {
            // Act
            var actual = Calculator.Instance.Calculate(v1, v2, Operation.Subtract);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, 4)]
        [TestCase(0, -2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, 0)]
        [TestCase(5, 5, 25)]
        [TestCase(5, -4, -20)]
        public void TestMultiply(float v1, float v2, float expected)
        {
            // Act
            var actual = Calculator.Instance.Calculate(v1, v2, Operation.Multiply);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 0.5f)]
        [TestCase(-2, -2, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(0, -2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-22, -2, 11)]
        public void TestDivide(float v1, float v2, float expected)
        {
            // Act
            var actual = Calculator.Instance.Calculate(v1, v2, Operation.Divide);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


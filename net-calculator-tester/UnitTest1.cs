namespace net_calculator_tester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddTwoNumbers([Values(8)] float num1, [Values(2)] float num2)
        {
           float result = Calculator.Add(num1, num2);

            Assert.AreEqual(10, result, "Result should be 10");
        }

        [Test]
        public void TestSubtractTwoNumbers([Values(8)] float num1, [Values(2)] float num2)
        {
            float result = Calculator.Subtract(num1, num2);

            Assert.AreEqual(6, result, "Result should be 6");
        }

        [Test]
        public void TestMultiplyTwoNumbers([Values(8)] float num1, [Values(2)] float num2)
        {
            float result = Calculator.Multiply(num1, num2);

            Assert.AreEqual(16, result, "Result should be 16");
        }

        [Test]
        public void TestDivideTwoNumbers([Values(8)] float num1, [Values(2)] float num2)
        {
            float result = Calculator.Divide(num1, num2);

            Assert.AreEqual(4, result, "Result should be 4");
        }
    }
}
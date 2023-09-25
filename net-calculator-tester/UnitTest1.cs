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

            Assert.AreEqual(10, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void Add_0And7_ShouldBe7()
        {
            Calculator c = new Calculator() { Result = 0 };
            c.Add(7);
            Assert.AreEqual(7, c.Result);
        }

        [TestMethod()]
        public void Subtract_10by5_ShouldBe5()
        {
            Calculator c = new Calculator() { Result = 10 };
            c.Subtract(5);
            Assert.AreEqual(5, c.Result);
        }

        [TestMethod]
        public void Subtract_10by1_ShouldBe9()
        {
            Calculator c = new Calculator() { Result = 10 };
            c.Subtract(1);
            Assert.AreEqual(9, c.Result);
        }

        [TestMethod()]
        public void Divide_10By2_ShouldBe5()
        {
            Calculator c = new Calculator() { Result = 10 };
            c.Divide(2);
            Assert.AreEqual(5, c.Result);
        }
    }
}
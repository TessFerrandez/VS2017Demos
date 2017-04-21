using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void Add_0And7_ShouldBe7()
        {
            Calculator c = new Calculator();
            c.Add(7);
            Assert.AreEqual(7, c.Amount);
        }

        [TestMethod()]
        public void Subtract_10by5_ShouldBe5()
        {
            Calculator c = new Calculator();
            c.Amount = 10;
            c.Subtract(5);
            Assert.AreEqual(5, c.Amount);
        }

        [TestMethod]
        public void Subtract_10by1_ShouldBe9()
        {
            Calculator c = new Calculator();
            c.Amount = 10;
            c.Subtract(1);
            Assert.AreEqual(9, c.Amount);
        }

        [TestMethod()]
        public void Divide_10By2_ShouldBe5()
        {
            Calculator c = new Calculator();
            c.Amount = 10;
            c.Divide(2);
            Assert.AreEqual(5, c.Amount);
        }
    }
}
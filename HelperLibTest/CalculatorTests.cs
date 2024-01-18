using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void PlusTest_NotEqual()
        {
            // Arrange
            
            // Act
            double l = Calculator.Plus(1.879, 2.199);

            // Assert
            Assert.AreNotEqual(l, 4.078);
        }

        [TestMethod()]
        public void PlusTest_Equal()
        {
            // Arrange

            // Act
            double l = Calculator.Plus(1.879, 2.199, -1);

            // Assert
            Assert.AreEqual((1.879 + 2.199), l);

        }
    }
}
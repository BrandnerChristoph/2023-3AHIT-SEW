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
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest_CreateEmptyObject()
        {
            // Arrange
            Person person = new Person();

            // Act

            // Assert
            Assert.IsNotNull(person);
            Assert.IsNull(person.Name);
        }

        [TestMethod()]
        public void PersonTest_CreateObject()
        {
            // Arrange
            Person p = new Person("Brandner", "Christoph", 190);
            
            // Act
            
            // Assert
            Assert.IsNotNull(p);
            Assert.AreEqual("Brandner", p.Name);
            Assert.AreNotEqual("Chris", p.Firstname);
            
        }

        [TestMethod()]
        public void PersonTest_IsPerson_Tall()
        {
            // Arrange
            Person p = new Person("Brandner", "Christoph", 190);

            // Act
            bool isTall = p.IsTall();

            // Assert
            Assert.IsTrue(isTall);

        }

    }
}
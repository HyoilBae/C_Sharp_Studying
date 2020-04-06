using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes.Tests
{
    [TestClass()]
    public class PersonTests
    {
        private static Person _testPersonLastName {get; set;}
        private static Person _testPersonFirstName {get; set;}
        private static Person _testPerson2 {get; set;}

        [TestInitialize()]
        public void InitializePersonTests()
        {
            _testPersonLastName = new Person("Smith");
            _testPersonFirstName = new Person("Jane", "Doe");
            _testPerson2 = new Person("John", "Smith");
        }

        [TestMethod()]
        public void DefaultConstructorPersonTest()
        {
            Assert.IsInstanceOfType(new Person(), typeof(Person));
        }

        [TestMethod()]
        public void ConstructorLastNamePersonTest()
        {
            Assert.IsTrue(_testPersonLastName.Lastname == "Smith");
        }

        [TestMethod()]
        public void ConstructorLastNameEmptyTest()
        {
            bool result = false;
            try
            {                
                _testPersonLastName = new Person(String.Empty);
            }
            catch (ArgumentOutOfRangeException)
            {
                result = true;                 
            }
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ConstructorFirstNamePersonTest()
        {
            Assert.IsTrue(_testPersonFirstName.FirstName == "Jane");
        }

        [TestMethod()]
        public void ConstructorFirstNameEmptyTest()
        {
            bool result = false;
            try
            {
                _testPersonFirstName = new Person(String.Empty, "Smith");
            }
            catch (ArgumentOutOfRangeException)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void PersonNotEqualTest()
        {
            Assert.IsFalse(_testPersonFirstName.Equals(_testPerson2));
        }

        [TestMethod()]
        public void PersonEqualTest()
        {
            Assert.IsTrue(_testPersonFirstName.Equals(new Person("Jane", "Doe")));
        }
    }
}
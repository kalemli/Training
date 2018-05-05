using System;
using DataProvider.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataProvider.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void SavePerson()
        {
            Constants.PersonJohn.Save();
        }

        [TestMethod]
        public void SaveEmployee()
        {
            var employee = new Employee();
            employee.Person = Constants.PersonJohn;
            employee.Salary = 100;

            employee.Save();
        }

        [TestMethod]
        public void GetPerson()
        {
            var person = Person.Get(p => p.Id == 1) as Person;
            Assert.IsNotNull(person);
            Assert.AreEqual(person.Name, Constants.PersonJohn.Name);
            Assert.AreEqual(person.Surname, Constants.PersonJohn.Surname);
            Assert.AreEqual(person.Lastname, Constants.PersonJohn.Lastname);
        }
    }
}

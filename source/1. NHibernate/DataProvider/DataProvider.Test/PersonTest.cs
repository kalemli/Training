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
            foreach (var person in Constants.PersonList)
                person.Save();
        }

        [TestMethod]
        public void SaveEmployee()
        {
            var employee = new Employee();
            employee.Person = Constants.PersonList[0];
            employee.Salary = 100;

            employee.Save();
        }

        [TestMethod]
        public void GetPerson()
        {
            var person = Person.Get(p => p.Id == 1) as Person;
            Assert.IsNotNull(person);
            Assert.AreEqual(person.Name, Constants.PersonList[0].Name);
            Assert.AreEqual(person.Surname, Constants.PersonList[0].Surname);
        }
    }
}

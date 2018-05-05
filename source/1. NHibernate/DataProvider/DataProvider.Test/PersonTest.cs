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
            Me.Save();
        }

        [TestMethod]
        public void SaveEmployee()
        {
            var employee = new Employee();
            employee.Person = Me;
            employee.Salary = 100;

            employee.Save();
        }

        public Person Me => new Person
        {
            Name = "John",
            Surname = "Coffey",
            Lastname = "???"
        };
}
}

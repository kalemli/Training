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
            foreach (dynamic data in Constants.DataList)
            {
                var person = new Person
                {
                    Name = data.FirstName,
                    Surname = data.Surname
                };
                person.PersonDetail = new PersonDetail
                {
                    Phone1 = data.Phone1,
                    Phone2 = data.Phone2,
                    Email = data.Email,
                    Web = data.Web,
                    Person = person
                };

                person.Save();
            }
        }

        [TestMethod]
        public void SaveEmployee()
        {
            var employee = new Employee();

            var data = Constants.DataList[0];
            employee.Person = new Person
            {
                Name = data.FirstName,
                Surname = data.Surname
            };
            employee.Salary = 100;

            employee.Save();
        }

        [TestMethod]
        public void GetPerson()
        {
            var person = Person.Get(p => p.Id == 1) as Person;
            Assert.IsNotNull(person);
        }
    }
}

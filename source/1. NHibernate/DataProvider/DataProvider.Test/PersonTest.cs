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
            var person = new Person();
            person.Name = "atif";
            person.Surname = "galamov";
            person.Lastname = "sabir";

            person.Save();
        }
    }
}

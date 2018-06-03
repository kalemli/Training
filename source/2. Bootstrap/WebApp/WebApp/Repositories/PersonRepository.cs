using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repositories
{
    public class PersonRepository
    {
        public static List<Person> GetPersonList()
        {
            return new List<Person>
            {
                new Person { Id = 1, FirstName = "Atif", LastName = "Galamov", Position = "Software Engineer" },
                new Person { Id = 2, FirstName = "Vagif", LastName = "Galamov", Position = "Network Administrator" }
            };
        }
    }
}

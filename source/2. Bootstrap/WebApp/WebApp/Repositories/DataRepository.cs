using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WebApp.Models;
using Microsoft.AspNetCore.Hosting;

namespace WebApp.Repositories
{
    public class DataRepository
    {
        public static string ContextRootPath { get; set; }
        public static List<Person> PersonList { get; set; }

        static DataRepository()
        {
            string data = File.ReadAllText(ContextRootPath + @"\data\MOCK_DATA.json");
            PersonList = JsonConvert.DeserializeObject<List<Person>>(data);
        }
    }
}

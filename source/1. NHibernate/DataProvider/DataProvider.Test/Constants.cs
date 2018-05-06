using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Test
{
    public class Constants
    {
        public static List<Person> PersonList { get; set; }

        static Constants()
        {
            PersonList = new List<Person>();
            string[] lines = File.ReadAllLines("us-500.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] columns = line.Split(',');
                PersonList.Add(new Person {
                    Name = columns[0].Replace("\"", ""),
                    Surname = columns[1].Replace("\"", "")
                });
            }
        }
    }
}
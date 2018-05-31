using System.Collections.Generic;
using System.IO;

namespace DataProvider.Test
{
    public class Constants
    {
        public static List<dynamic> DataList { get; set; }

        static Constants()
        {
            DataList = new List<dynamic>();
            string[] lines = File.ReadAllLines("us-500.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] columns = line.Split(',');

                DataList.Add(new
                {
                    FirstName = columns[0].Replace("\"", ""),
                    Surname = columns[1].Replace("\"", ""),
                    CompanyName = columns[2].Replace("\"", ""),
                    Address = columns[3].Replace("\"", ""),
                    City = columns[4].Replace("\"", ""),
                    Country = columns[5].Replace("\"", ""),
                    State = columns[6].Replace("\"", ""),
                    Zip = columns[7].Replace("\"", ""),
                    Phone1 = columns[8].Replace("\"", ""),
                    Phone2 = columns[9].Replace("\"", ""),
                    Email = columns[10].Replace("\"", ""),
                    Web = columns[11].Replace("\"", "")
                });
            }
        }
    }
}
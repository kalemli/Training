using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    public class DataController : Controller
    {
        [HttpGet]
        [Route("api/data/person-list")]
        public List<Person> GetPersonList()
        {
            return PersonList;
        }

        private List<Person> PersonList
        {
            get
            {
                if (_PersonList == null)
                {
                    string data = System.IO.File.ReadAllText(_env.ContentRootPath + @"\wwwroot\data\MOCK_DATA.json");
                    _PersonList = JsonConvert.DeserializeObject<List<Person>>(data);
                }
                return _PersonList;
            }
        }

        private IHostingEnvironment _env;
        private static List<Person> _PersonList;

        public DataController(IHostingEnvironment env)
        {
            _env = env;
        }
    }
}
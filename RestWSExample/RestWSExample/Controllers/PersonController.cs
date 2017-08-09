using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestWSExample.Models;

namespace RestWSExample.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public string getName(string ad,string soyad)
        {
            return "Ad: " + ad + " Soyad: " + soyad;
        }

        [HttpGet]
        public List<Person> getPersons(string ad)
        {
            List<Person> prsns = new List<Person>();
            prsns.Add(new Person { name = "tanju", surname = "vonal" });
            prsns.Add(new Person { name = "ali", surname = "veli" });
            prsns.Add(new Person { name = "ali3", surname = "veli3" });
            return prsns;
        }
    }
}

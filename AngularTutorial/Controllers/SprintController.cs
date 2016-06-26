using AngularTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularTutorial.Controllers
{
    public class SprintController : ApiController
    {
        private DB db = new DB();

        // POST api/<controller>
        public void Post([FromBody]Sprint value)
        {
            db.Sprints.Add(value);
            db.SaveChanges();
        }
        
    }
}
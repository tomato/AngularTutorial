using AngularTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularTutorial.Controllers
{
    public class ProjectController : ApiController
    {
        // GET api/Project
        public Project Get()
        {
            return new Project(new DB().Sprints);
        }
    }
}
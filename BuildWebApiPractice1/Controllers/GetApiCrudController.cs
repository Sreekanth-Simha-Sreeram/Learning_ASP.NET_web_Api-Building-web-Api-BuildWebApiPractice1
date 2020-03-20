using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildWebApiPractice1.Controllers
{
    public class GetApiCrudController : ApiController
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
           // code here for grt api and returns the collection of book and returns the book with the provided identifier.

            return null;
        }

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            //code here to get api by id
            return "value";
        }

      
        
    }
}

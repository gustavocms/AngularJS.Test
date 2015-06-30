using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chep.Test.API.Controllers.Api
{
    public class RandomNumberController : ApiController
    {
        // GET api/RandomNumber
        public int Get()
        {
            Random rnd = new Random();
            int num = rnd.Next(3, 10);
            return num;
        }
    }
}

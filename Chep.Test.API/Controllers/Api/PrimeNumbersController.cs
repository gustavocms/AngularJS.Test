using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace Chep.Test.API.Controllers.Api
{
    public class PrimeNumbersController : ApiController
    {
        // GET api/PrimeNumbers/IsPrimeNumber
        [Route("api/PrimeNumbers/IsPrimeNumber")]
        [HttpGet]
        public bool IsPrimeNumber(int number)
        {
            return PrimeNumberHelper.IsPrimeNumber(number);
        }

        // GET api/PrimeNumbers/ListPrimeNumbers
        [Route("api/PrimeNumbers/ListPrimeNumbers")]
        [HttpGet]
        public List<int> ListPrimeNumbers(int start, int end)
        {
            return PrimeNumberHelper.ListPrimeNumbers(start, end);
        }
    }
}

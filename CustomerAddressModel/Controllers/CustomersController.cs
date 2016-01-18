using CustomerAddressModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerAddressModel.Controllers
{
    public class CustomersController : ApiController
    {
        public IHttpActionResult Post(Customer customer)
        {
            return Ok();
        }
    }
}

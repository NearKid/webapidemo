﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class TestController : ApiController
    {

        // DELETE: api/Test/5
        public IHttpActionResult Test(int id)
        {
            return Ok();
        }
    }
}

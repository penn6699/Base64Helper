using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Base64Helper.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public dynamic e64() {
            return "ddd";
        }


    }
}

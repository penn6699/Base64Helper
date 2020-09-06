using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Base64HelperDemo.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public dynamic e64(string t) {
            return Base64Helper.Encode(t);
        }
        [HttpGet]
        public dynamic d64(string t)
        {
            return Base64Helper.Decode(t);
        }
        [HttpGet]
        public dynamic e64url(string t)
        {
            return Base64Helper.EncodeUrl(t);
        }
        [HttpGet]
        public dynamic d64url(string t)
        {
            return Base64Helper.DecodeUrl(t);
        }
    }
}

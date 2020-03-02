using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestP2.Models;

namespace RestP2.Controllers
{
    public class SalesController : ApiController
    {
        private ShopEntities db = new ShopEntities();
        public IHttpActionResult Get()
        {
            var res = db.Sales.ToArray();

            return Ok(res);
        }
    }
}

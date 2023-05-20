using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace TesteGenesis.Api.Controllers
{
    public class CdbController : System.Web.Http.ApiController
    {
        public HttpResponseMessage CanclularCdb(int meses, decimal valor)
        {
            return Request.CreateResponse<decimal>(HttpStatusCode.OK, 0m);
        }
    }
}
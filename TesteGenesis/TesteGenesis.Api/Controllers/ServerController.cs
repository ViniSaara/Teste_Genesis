using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteGenesis.Api.Controllers
{
    public class ServerController : System.Web.Http.ApiController
    {
        [HttpGet]
        public bool ServidorDisponivel(int id)
        {
            return true;
        }
    }
}
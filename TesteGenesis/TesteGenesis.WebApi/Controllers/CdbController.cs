using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TesteGenesis.WebApi.Models;
using TesteGenesis.WebApi.Servicos;

namespace TesteGenesis.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CdbController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage CalcularCdb(int meses, decimal valorInicial)
        {
            Calculos calculos = new Calculos();
            var resultado = calculos.CalcularCdb(meses, valorInicial);

            return Request.CreateResponse<RendimentosCdb>(HttpStatusCode.OK, resultado);
        }
    }
}
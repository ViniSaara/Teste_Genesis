using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TesteGenesis.Api.Models;
using TesteGenesis.Api.Servicos;

namespace TesteGenesis.Api.Controllers
{
    public class CdbController : System.Web.Http.ApiController
    {
        public HttpResponseMessage CalcularCdb(int meses, decimal valorInicial)
        {
            Calculos calculos = new Calculos();
            
            try
            {
                var resultado = calculos.CalcularCdb(meses, valorInicial);

                return Request.CreateResponse<RendimentosCdb>(HttpStatusCode.OK, resultado);
                    
            }
            catch (Exception ex)
            {
                return Request.CreateResponse<string>(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
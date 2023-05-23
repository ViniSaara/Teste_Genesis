using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteGenesis.WebApi.Models
{
    public class RendimentosCdb
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public string Mensagem { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TesteGenesis.Api.Models;

namespace TesteGenesis.Api.Servicos
{
    public class Calculos
    {
        private const decimal tb = 1.08m;
        private const decimal cdi = 0.009m;

        public RendimentosCdb CalcularCdb(int meses, decimal valorInicial)
        {
            string msgValidacao = ValidarDados(meses, valorInicial);
            if (!string.IsNullOrEmpty(msgValidacao))
                throw new Exception(msgValidacao);

            decimal valorLiquido = 0m;
            decimal valorFinal = valorInicial;

            for (int i = 0; i < meses; i++)
                valorFinal = Math.Round(valorFinal * (1 + (cdi * tb)), 2);

            valorLiquido = valorFinal - valorInicial;

            return new RendimentosCdb() { ValorBruto = valorFinal, ValorLiquido = valorLiquido };
        }

        private string ValidarDados(int meses, decimal valorInicial)
        {
            if (meses <= 1)
                return "A quantidade de meses deve ser maior que 1";

            if (valorInicial <= 0)
                return "O valor deve ser positivo";

            return "";
        }
    }
}
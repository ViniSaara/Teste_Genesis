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
        private const decimal TB = 1.08m;
        private const decimal CDI = 0.009m;
        private const decimal PERCENTUAL_IMPOSTO_MENOS_6_MESES = 0.225m;
        private const decimal PERCENTUAL_IMPOSTO_ENTRE_7_E_12_MESES = 0.20m;
        private const decimal PERCENTUAL_IMPOSTO_ENTRE_13_E_24_MESES = 0.175m;
        private const decimal PERCENTUAL_IMPOSTO_ACIMA_24_MESES = 0.15m;

        public RendimentosCdb CalcularCdb(int meses, decimal valorInicial)
        {
            string msgValidacao = ValidarDados(meses, valorInicial);
            if (!string.IsNullOrEmpty(msgValidacao))
                return new RendimentosCdb() { Mensagem = msgValidacao};

            decimal valorLiquido = 0m, valorRendimentoComImposto = 0m, valorImpostoASerCobrado = 0m;
            decimal valorBruto = valorInicial;

            for (int i = 0; i < meses; i++)
                valorBruto = valorBruto * (1 + (CDI * TB));

            valorRendimentoComImposto = valorBruto - valorInicial;

            valorImpostoASerCobrado = CalcularImpostoSobreValorRendido(meses, valorRendimentoComImposto);

            valorLiquido = valorBruto - valorImpostoASerCobrado;

            valorBruto = Math.Round(valorBruto, 2);
            valorLiquido = Math.Round(valorLiquido, 2);

            return new RendimentosCdb() { ValorBruto = valorBruto, ValorLiquido = valorLiquido };
        }

        private  decimal CalcularImpostoSobreValorRendido(int meses, decimal valorTotalRendimento)
        {
            decimal valorImpostoASerCobrado = 0m;

            if (meses <= 6)
                valorImpostoASerCobrado = valorTotalRendimento * PERCENTUAL_IMPOSTO_MENOS_6_MESES;
            else if (meses <= 12)
                valorImpostoASerCobrado = valorTotalRendimento * PERCENTUAL_IMPOSTO_ENTRE_7_E_12_MESES;
            else if (meses <= 24)
                valorImpostoASerCobrado = valorTotalRendimento * PERCENTUAL_IMPOSTO_ENTRE_13_E_24_MESES;
            else
                valorImpostoASerCobrado = valorTotalRendimento * PERCENTUAL_IMPOSTO_ACIMA_24_MESES;

            return valorImpostoASerCobrado;
        }

        private string ValidarDados(int meses, decimal valorInicial)
        {
            if (meses <= 1)
                return "A quantidade de meses deve ser maior que 1";

            if (valorInicial <= 0)
                return "O valor inicial deve ser positivo";

            return "";
        }
    }
}
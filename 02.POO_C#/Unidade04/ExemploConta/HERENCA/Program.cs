using System;

namespace HERENCA
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente = new ContaCorrente();
            var contaPoupanca = new ContaPoupanca();

            ExibirSaldo.ExibirEmTela(contaCorrente);
            ExibirSaldo.ExibirEmTela(contaPoupanca);
            Console.ReadKey();

            

            var boletoBancodoSul = new BoletoBancoDoSul();
            var geradorBoletoBancoDoSul = new GeradorBoleto(boletoBancodoSul);
            boletoBancodoSul.GerarCodigoBarras();
            var boletoBancodoNorte = new BoletoBancoDoNorte();
            var geradorBoletoBancoDoNorte = new GeradorBoleto(boletoBancodoNorte);
            boletoBancodoNorte.GerarCodigoBarras();


        }
    }
}


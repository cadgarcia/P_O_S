using System;
namespace HERENCA
{
    public class GeradorBoleto
    {


        //readonly determina que depois que o atributo seja instanciado não poderá ser alterado
        private readonly IBoleto _boleto;

        public GeradorBoleto(IBoleto boleto)
        {
            //underscore é uma convenção para atributos privados
            _boleto = boleto;
        }

        public void MontarBoleto() {
            var codigoBarras = _boleto.GerarCodigoBarras();
            //lógica pra gerar código de barras
        }
    }
}


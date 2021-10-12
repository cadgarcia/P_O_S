using System;
namespace HERENCA
{
    public class BoletoBancoDoSul : IBoleto
    {
        public BoletoBancoDoSul()
        {

        }

        public string GerarCodigoBarras()
        {
            //aqui lógica para criar código de barras para este banco
            return "";
        }
    }
}


using System;
namespace HERENCA
{
    public class BoletoBancoDoNorte : IBoleto
    {
        public string GerarCodigoBarras()
        {
            return "123456";
        }
    }
}


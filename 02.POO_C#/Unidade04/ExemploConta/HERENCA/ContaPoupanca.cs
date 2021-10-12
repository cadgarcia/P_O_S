using System;
namespace HERENCA
{
    public class ContaPoupanca : Conta
    {
        public override bool Sacar(decimal valor)
        {
            return true;
        }
    }
}


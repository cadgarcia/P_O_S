using System;
namespace HERENCA
{
    //o modificador sealed IMPEDE que esta classe seja herdada por outra
    //é o equivalente ao finally do java
    sealed public class ContaCorrente : Conta
    {
        public decimal Limite { get; private set; }

        override public bool Sacar(decimal valor) {
            if ((Saldo + Limite) >= valor )
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}


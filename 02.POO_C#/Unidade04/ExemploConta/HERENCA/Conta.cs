using System;
namespace HERENCA
{
    abstract public class Conta
    {

        public decimal Saldo { get; protected set; }
        //protected:
        //se fosse privated, não seria possível manipular nas classes filhas desta
        //o protected permite que sejam manipuladas nas classes filhas

        //o modificar virtual permite que os métodos sejam sobrescritos nas classes filhas
        //o modificador virtual permite que os métodos sejam sobrescritos nas classes filhas
        public void Depositar(decimal valor) {
            this.Saldo += valor;
        }

        // método abstract OBRIGA todas classes filhas a reimplementar o mesmo
        public abstract bool Sacar(decimal valor);

    }
}


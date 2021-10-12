using System;
namespace HERENCA
{
    //classe estática, não precisa instanciar
    public static class ExibirSaldo
    {

        public static void ExibirEmTela(Conta conta)
        {
            var saldo = conta.Saldo;

            //se o parâmetro conta for do tipo ContaCorrente, armazene na variável conta corrente
            if (conta is ContaCorrente contaCorrente)
            {
                var limite = contaCorrente.Limite;
            }
        }
        
    }
}


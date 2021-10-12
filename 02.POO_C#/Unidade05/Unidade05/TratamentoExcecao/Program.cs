using System;

namespace TratamentoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Início do código");
                var valor = 10;
                var erro = valor / 0;
                Console.WriteLine("Continuação do código");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


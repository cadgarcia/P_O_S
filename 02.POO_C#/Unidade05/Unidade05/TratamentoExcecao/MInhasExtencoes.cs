using System;
namespace TratamentoExcecao
{
    public static class MInhasExtencoes
    {
        public static bool EhUmCPF(this string texto) {
            return texto.Length == 11;
        }

        public static bool EhMeuAniversario(DateTime data) {
            return data.Date == new DateTime(1974, 3, 16).Date; 
        }
    }
}


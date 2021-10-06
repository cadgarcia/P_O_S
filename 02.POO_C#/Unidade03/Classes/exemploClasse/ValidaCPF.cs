using System;
namespace exemploClasse
{
    public static class ValidaCPF
    {
        public static bool Valida(string cpf) {
            return cpf.Length == 11;
        }
    }
}


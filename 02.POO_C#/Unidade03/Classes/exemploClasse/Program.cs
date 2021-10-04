using System;

namespace exemploClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = new string[3];
            emails[0] = "email1@bol.com";
            emails[1] = "teste@yahoo.com";
            emails[2] = "caixa@zipmail.com";
            Cliente c1 = new Cliente(1, "Luiz Silva", 2500, emails);

            Cliente c2 = new Cliente(2, "Maria", 1500, emails);
            c2.PromoverCliente(9000);

            c1.ImprimeCliente();
            c2.ImprimeCliente();

        }
    }
}

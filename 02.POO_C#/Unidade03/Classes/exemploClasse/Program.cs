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
            Cliente c1 = new Cliente(1, "Luiz Silva", 2500, emails, "12345678901");

            Cliente c2 = new Cliente(2, "Maria", 1500, emails, "0987654321");
            c2.PromoverCliente(9000);

            Venda v1 = new Venda();
            v1.Descricao = "tenis";
            v1.Valor = 1000;
            c1.AdicionarVenda(v1);

            Venda v2 = new Venda();
            v2.Descricao = "sofá";
            v2.Valor = 4500;
            c1.AdicionarVenda(v2);

            c1.ImprimeCliente();
            c2.ImprimeCliente();

            c1.CalcularVendas();
        }
    }
}

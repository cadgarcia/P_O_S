using System;
using System.Collections.Generic;
using exemploClasse.Enumeracoes;

namespace exemploClasse
{
    public class Cliente
    {
        //construtor
        public Cliente() { }

        //constantes
        public const decimal RENDA_MENSAL_MASTER = 5000;
        public const decimal RENDA_MENSAL_PREMIUM = 2500;
        public const decimal VALOR_EM_COMPRAS_MASTER = 8000;
        public const decimal VALOR_EM_COMPRAS_PREMIUM = 5000;

        //construtor com parâmetros
        public Cliente(int codigo, string nome, decimal rendaMensal, string[] emails, string cpf)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.RendaMensal = rendaMensal;
            this.Classificacao = DefinirClassificacao();
            this.Emails = emails;
            this.Cpf = cpf;
            this.CpfOk = ValidaCPF.Valida(cpf);
            Vendas = new List<Venda>();
        }

        /*
        public int codigo;
        public string nome;
        public bool clientePremium;
        public decimal rendaMensal; 
        */
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public ENivelClassificacao Classificacao { get; private set; }
        public decimal RendaMensal { get; set; }
        public string[] Emails { get; set; }
        public string Cpf { get; set; }
        public bool CpfOk { get; set; }
        public List<Venda> Vendas { get; set; }



        private ENivelClassificacao DefinirClassificacao()
        {
            if(this.RendaMensal >= RENDA_MENSAL_MASTER){
                return this.Classificacao = ENivelClassificacao.master;
            }
            if (this.RendaMensal >= RENDA_MENSAL_PREMIUM)
            {
                return this.Classificacao = ENivelClassificacao.premium;
            }
            else {
                return this.Classificacao = ENivelClassificacao.padrão;
            }
        }

        public void PromoverCliente(decimal totalCompras)
        {
            if (totalCompras >= VALOR_EM_COMPRAS_MASTER && this.Classificacao != ENivelClassificacao.master)
            {
                this.Classificacao = ENivelClassificacao.master;
            }
            if (totalCompras >= VALOR_EM_COMPRAS_PREMIUM && this.Classificacao != ENivelClassificacao.master)
            {
                this.Classificacao = ENivelClassificacao.premium;
            }
        }

        public string resgatarListaEmails() {
            var listaEmails = "O cliente possui " + Emails.Length + " e-mails: \n";
            foreach (var item in Emails)
            {
                listaEmails += item + "\n";
            }
            return listaEmails;
        }

        public void AdicionarVenda(Venda vv)
        {

            Vendas.Add(vv);
        }

        public void CalcularVendas() {
            decimal total = 0;
            foreach (var item in Vendas)
            {
                total += item.Valor;
            }
            Console.WriteLine("Total de vendas: {0}", total);
        }

        public void ImprimeCliente() {
            Console.WriteLine("Nome: " + this.Nome.ToString());
            Console.WriteLine("Código: " + this.Codigo.ToString());
            Console.WriteLine("Renda Mensal: " + this.RendaMensal.ToString());
            Console.WriteLine("Tipo de Cliente: " + this.Classificacao.ToString());
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("CPF ok?: " + this.CpfOk);
            Console.WriteLine("Emails: " + resgatarListaEmails());
            Console.WriteLine();
        }
    }
}

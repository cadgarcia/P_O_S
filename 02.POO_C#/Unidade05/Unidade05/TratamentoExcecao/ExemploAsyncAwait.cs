using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TratamentoExcecao
{
    public class ExemploAsyncAwait
    {
        //método síncrono:
        public void Sincrono() {
            HttpClient client = new HttpClient();
            string conteudo = client.GetStringAsync("http://msdn.microsoft.com").GetAwaiter().GetResult();

            Console.WriteLine("Tamanho da página: {0}", conteudo);
        }

        //método assíncrono:
        public async void Assincrono() {
            // a variavel fica aguardando (await) pelo retorno de outro metódo
            var tamanho = await AcessaWebAssinc();
            Console.WriteLine("Tamanho da página: {0}", tamanho);
        }

        //retorno que precisa ser aguardado do tipo int (Taks<int>)
        public async Task<int> AcessaWebAssinc() {

            HttpClient client = new HttpClient();

            Task<string> retorno = client.GetStringAsync("http://msdn.microsoft.com");

            // com o uso se await o runtime sabe que precisa esperar esta tarefa ser concluída
            string resultado = await retorno;

            return resultado.Length;
        }
    }
}


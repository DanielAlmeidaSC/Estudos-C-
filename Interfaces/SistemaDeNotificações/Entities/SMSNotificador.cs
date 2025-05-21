using SistemaDeNotificações.Interfaces;
using System.Globalization;
using System.IO;

namespace SistemaDeNotificações.Entities
{
    public class SMSNotificador : INotificador
    {
        public DateTime Data { get; set; } = DateTime.Now;
        
        public void Enviar()
        {
            CriarBlocoDeMensagem();
        }
        public void CriarBlocoDeMensagem()
        {
            string caminho = @"D:\Estudos C#\Interfaces\SistemaDeNotificações\Blocos SMS";

            try
            {

                if (Path.Exists(caminho))
                {
                    Console.WriteLine("Digite o assunto do SMS: ");
                    string assunto = Console.ReadLine() ?? "0";

                    Console.WriteLine("Escreva o SMS: ");
                    string texto = Console.ReadLine() ?? "0";

                    string novoCaminho = Path.Combine(caminho + @$"\{assunto}");

                    string data = "Data de envio: " + Data.ToString("G", new CultureInfo("pt-BR"));

                    File.WriteAllText(novoCaminho, texto + "\n\n\n");
                    File.AppendAllText(novoCaminho, data);

                    Console.WriteLine("Mensagem enviada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Caminho não encontrado!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro: " + e.Message);
            }

        }
       
    }
}
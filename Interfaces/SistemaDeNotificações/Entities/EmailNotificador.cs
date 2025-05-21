using SistemaDeNotificações.Interfaces;
using System.Globalization;

namespace SistemaDeNotificações.Entities
{
    public class EmailNotificador : INotificador
    {
        public DateTime Data { get; set; } = DateTime.Now;

        public void Enviar()
        {
            CriarBlocoDeMensagem();
        }
        public void CriarBlocoDeMensagem()
        {
            string origem = @"D:\Estudos C#\Interfaces\SistemaDeNotificações\Blocos email";

            try
            {

                if (Path.Exists(origem))
                {
                    Console.WriteLine("Digite o assunto do E-mail: ");
                    string assunto = Console.ReadLine() ?? "0";

                    Console.WriteLine("Escreva o E-mail: ");
                    string texto = Console.ReadLine() ?? "0";

                    string novoCaminho = Path.Combine(origem + @$"\{assunto}");

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
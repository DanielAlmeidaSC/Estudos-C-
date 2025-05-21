using System;
using SistemaDeNotificações.Entities;
using SistemaDeNotificações.Interfaces;

namespace SistemaDeNotificações
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você deseja enviar um SMS ou E-mail: ");
            string opcao = Console.ReadLine() ?? "0";

            opcao = opcao.ToLower();

            if (opcao == "sms")
            {
                INotificador correio = new SMSNotificador();

                correio.Enviar();
            }
            else if (opcao == "e-mail" || opcao == "email")
            {
                INotificador correio = new EmailNotificador();
                correio.Enviar();
            }



        }
    }
}
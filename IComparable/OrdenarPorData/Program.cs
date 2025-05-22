using System;
using System.Collections.Generic;

namespace OrdenarPorData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Evento> eventos = new List<Evento>();

            eventos.Add(new Evento("Casamento", new DateTime(2025, 06, 12)));
            eventos.Add(new Evento("Aniversário Daniel", new DateTime(2025, 08, 30)));
            eventos.Add(new Evento("Aniversário Ariele", new DateTime(2025, 12, 16)));
            eventos.Add(new Evento("Aniversário Mãe", new DateTime(2025, 08, 07)));

            eventos.Sort();
            foreach (Evento evento in eventos)
            {
                Console.WriteLine("Evento: " + evento.Nome + " Data: " + evento.Data);
            }

        }
    }
}
using System;
using Enums;


namespace Classes
{
    public class Estacao
    {
        public static void RetornarEstacao (string mes){
            
            if (!Enum.TryParse<MesAno>(mes, true, out MesAno mesEnum)){
                Console.WriteLine("Mes inválido!");
            }

            switch (mesEnum)
            {
                case MesAno.Dezembro:
                case MesAno.Janeiro:
                case MesAno.Fevereiro:
                    Console.WriteLine("Verão!");
                    break;
                case MesAno.Março:
                case MesAno.Abril:
                case MesAno.Maio:
                    Console.WriteLine("Outono!");
                    break;
                case MesAno.Junho:
                case MesAno.Julho:
                case MesAno.Agosto:
                    Console.WriteLine("Inverno!");
                    break;
                case MesAno.Setembro:
                case MesAno.Outubro:
                case MesAno.Novembro:
                    Console.WriteLine("Primavera!");
                    break;
                default:
                    Console.WriteLine("Estação desconhecida!");
                    break;
            }
        }         
    }
}
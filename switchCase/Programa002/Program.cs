using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
        Console.WriteLine("Ler uma letra (A, B, C) e imprimir o nome de um animal.");
        Console.WriteLine("Digite: ");
        char letra = char.Parse(Console.ReadLine()??"0");
        letra = char.ToUpper(letra);
        switch (letra)
        {
            case 'A':
             Console.WriteLine("Anta");
            break;

            case 'B':
             Console.WriteLine("Bicho-preguiça");
            break;

            case 'C':
             Console.WriteLine("Canguru");
            break;

            case 'D':
             Console.WriteLine("Dromedário");
            break;

            case 'E':
             Console.WriteLine("Elefante");
            break;

            case 'F':
             Console.WriteLine("Foca");
            break;

            case 'G':
             Console.WriteLine("Gato");
            break;

            case 'H':
             Console.WriteLine("Hipopótamo");
            break;

            case 'I':
             Console.WriteLine("Iguana");
            break;

            case 'J':
             Console.WriteLine("Jacaré");
            break;

            case 'K':
             Console.WriteLine("Kiwi (ave)");
            break;

            case 'L':
             Console.WriteLine("Leão");
            break;

            case 'M':
             Console.WriteLine("Macaco");
            break;

            case 'N':
             Console.WriteLine("Narval");
            break;

            case 'O':
             Console.WriteLine("Ornitorrinco");
            break;

            case 'P':
             Console.WriteLine("Pinguim");
            break;

            case 'Q':
             Console.WriteLine("Quati");
            break;

            case 'R':
             Console.WriteLine("Rinoceronte");
            break;

            case 'S':
             Console.WriteLine("Suricata");
            break;

            case 'T':
             Console.WriteLine("Tigre");
            break;

            case 'U':
             Console.WriteLine("Urso");
            break;

            case 'V':
             Console.WriteLine("Vaca");
            break;

            case 'W':
             Console.WriteLine("Wapiti (espécie de cervo)");
            break;

            case 'X':
             Console.WriteLine("Xerus (espécie de esquilo africano)");
            break;

            case 'Y':
             Console.WriteLine("Yak");
            break;

            case 'Z':
             Console.WriteLine("Zebra");
            break;

            default:
            Console.WriteLine("Opção inválida!");
            break;
        }
        
        }
    }
}
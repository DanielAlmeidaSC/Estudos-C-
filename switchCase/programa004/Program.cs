using System;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Criar um sistema de cores (Red, Blue, Green) usando `switch`.");

            Console.WriteLine("Digite uma letra que responderemos com uma cor correspondente: ");
            char letra = char.Parse(Console.ReadLine()??"0");

            letra = char.ToUpper(letra);

            switch (letra)
            {
            case 'A':
             Console.WriteLine("Amber");
            break;
            case 'B':
             Console.WriteLine("Blue");
            break;
            case 'C':
             Console.WriteLine("Cyan");
            break;
            case 'D':
             Console.WriteLine("Dark Red");
            break;
            case 'E':
             Console.WriteLine("Emerald");
            break;
            case 'F':
             Console.WriteLine("Fuchsia");
            break;
            case 'G':
             Console.WriteLine("Green");
            break;
            case 'H':
             Console.WriteLine("Honeydew");
            break;
            case 'I':
             Console.WriteLine("Indigo");
            break;
            case 'J':
             Console.WriteLine("Jade");
            break;
            case 'K':
             Console.WriteLine("Khaki");
            break;
            case 'L':
             Console.WriteLine("Lavender");
            break;
            case 'M':
             Console.WriteLine("Magenta");
            break;
            case 'N':
             Console.WriteLine("Navy");
            break;
            case 'O':
             Console.WriteLine("Olive");
            break;
            case 'P':
             Console.WriteLine("Purple");
            break;
            case 'Q':
             Console.WriteLine("Quartz (Rose Quartz)");
            break;
            case 'R':
             Console.WriteLine("Red");
            break;
            case 'S':
             Console.WriteLine("Silver");
            break;
            case 'T':
             Console.WriteLine("Turquoise");
            break;
            case 'U':
             Console.WriteLine("Umber");
            break;
            case 'V':
             Console.WriteLine("Violet");
            break;
            case 'W':
             Console.WriteLine("White");
            break;
            case 'X':
             Console.WriteLine("Xanadu (um tom acinzentado-esverdeado)");
            break;
            case 'Y':
             Console.WriteLine("Yellow");
            break;
            case 'Z':
             Console.WriteLine("Zaffre (um azul profundo)");
            break;
                default:
                Console.WriteLine("Opção inválida!");
                break;
            }

        }
    }
}
using System;

namespace Programa004
{
    public struct Posicao
    {
        public int X = 0;
        public int Y = 0;

        public Posicao()
        {
        }

        public void MoverJogador()
        {
            Console.WriteLine("Mova o jogador: ");
            string opcao = Console.ReadLine() ?? "0";

            if (opcao.ToLower() == "a")
            {
                Y--;
            }
            else if (opcao.ToLower() == "d")
            {
                Y++;
            }
            else if (opcao.ToLower() == "w")
            {
                X++;
            }
            else if (opcao.ToLower() == "s")
            {
                X--;
            }


            Console.WriteLine("Posição X: " + X);
            Console.WriteLine("Posição Y: " + Y);

            while (true)
            {
                Console.WriteLine("Mova o jogador. Digite 'sair' para encerrar: ");
                opcao = Console.ReadLine() ?? "0";
                
                if(opcao.ToLower() == "sair"){
                    break;
                }


                if (opcao.ToLower() == "a")
                {
                    Y--;
                }
                else if (opcao.ToLower() == "d")
                {
                    Y++;
                }
                else if (opcao.ToLower() == "w")
                {
                    X++;
                }
                else if (opcao.ToLower() == "s")
                {
                    X--;
                }

                Console.WriteLine("Posição X: " + X);
                Console.WriteLine("Posição Y: " + Y);
            }
        }
    }
}
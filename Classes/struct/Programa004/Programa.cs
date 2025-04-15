using System;

namespace Programa004 {
    internal class Programa {
        static void Main(string[] args) {
            Jogador jogador1 = new Jogador("Daniel", 100);
            Posicao posicao1 = new Posicao();

            jogador1.MoverJogador();

            Console.WriteLine("Você deseja mudar de nome: ");
            string opcao = Console.ReadLine()??"0";

            if(opcao.ToLower() == "sim"){
                jogador1.AlterName();
                jogador1.DadosUsuario();
            }else{
                Console.WriteLine("Você deseja percorrer pelo mapa: ");
                string opcaoPercorrer = Console.ReadLine()??"0";

                if(opcaoPercorrer.ToLower() == "sim"){

                jogador1.MoverJogador();    
                }
            }
        
        }
    }
}
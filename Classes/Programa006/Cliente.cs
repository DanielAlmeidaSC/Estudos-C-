using System;

namespace Programa006 {
   class Cliente {

    public string Nome;
    public int Idade;      
    public string Email;


    public void ExibirInformacoes(){
        Console.WriteLine("Nome: "+Nome);
        Console.WriteLine("Idade: "+Idade);
        Console.WriteLine("E-mail: "+Email);
       
        }


    }
}
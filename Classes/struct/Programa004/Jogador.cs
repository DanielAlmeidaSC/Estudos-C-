using System;

namespace Programa004 {
   class Jogador{

    private string _name = " ";
    private int _life;
    public Posicao Posicao;

    public string Name {
        get{ return _name; }
    }

    public int Life {
        get{ return _life; }
    }

    public Jogador(string name, int life){
        _name = name;
        _life = life;
    }

    public void AlterName(){
        Console.WriteLine("Digite o seu novo nome: ");  
        string newName = Console.ReadLine()??"0";

        _name = newName;
    }

    public void MoverJogador(){
        Posicao.MoverJogador();
    }


    public void DadosUsuario(){
        Console.WriteLine("Nome: "+_name);
        Console.WriteLine("Vida: "+_life);
    }
    }
}
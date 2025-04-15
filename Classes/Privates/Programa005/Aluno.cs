//Classe Aluno com os atributos privados nome, nota1, nota2. Criar uma property Media (só leitura) que calcula a média.

using System;

namespace Programa005 {
   class Aluno{

    private string _nome = " ";
    private double _nota1;
    private double _nota2;


    public string Nome
    {
        set { _nome = value; }
        get { return _nome; }
    }
    
    public double Nota1
    {
        set { _nota1 = value; }
        get { return _nota1; }
    }

    public Aluno(string nome, double nota1, double nota2){
        _nome = nome;
        _nota1 = nota1;
        _nota2 = nota2;
    }
    public double Nota2
    {
        set { _nota2 = value; }
        get { return _nota2; }
    }
    
    public double Media {
        get{ return (Nota1+Nota2)/2; }
    }




    }
}
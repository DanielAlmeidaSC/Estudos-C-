using System;

namespace Programa001 {
   public struct Endereco {

    public string Rua;    
    public string Cidade;
    public int Numero;

    public Endereco (string rua, int numero, string cidade){
        Rua = rua;
        Cidade = cidade;
        Numero = numero;
    }
    public string ExibirEndereco() {
        return $"{Rua}, N°{Numero} - {Cidade}";

    }

    }
}
using System;
using System.Collections.Generic;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {
        
        //Crie um `Dictionary<string, int>` usando `var`. É um dicionário de capitais de estados brasileiros


        var estado = new Dictionary<string, string>();

        estado.Add("Santa Catarina", "Florianópolis");
        estado.Add("Rio de Janeiro", "Rio de Janeiro");
        estado.Add("São Paulo", "São Paulo");
        estado.Add("Acre", "Rio Branco");
        estado.Add("Alagoas", "Maceió");
        estado.Add("Amapá", "Macapá");
        estado.Add("Amazonas", "Manaus");
        estado.Add("Bahia", "Salvador");
        estado.Add("Ceará", "Fortaleza");
        estado.Add("Distrito Federal", "Brasília");
        estado.Add("Espírito Santo", "Vitória");
        estado.Add("Goiás", "Goiânia");
        estado.Add("Maranhão", "São Luís");
        estado.Add("Mato Grosso", "Cuiabá");
        estado.Add("Mato Grosso do Sul", "Campo Grande");
        estado.Add("Minas Gerais", "Belo Horizonte");
        estado.Add("Pará", "Belém");
        estado.Add("Paraíba", "João Pessoa");
        estado.Add("Paraná", "Curitiba");
        estado.Add("Pernambuco", "Recife");
        estado.Add("Piauí", "Teresina");
        estado.Add("Rio Grande do Norte", "Natal");
        estado.Add("Rio Grande do Sul", "Porto Alegre");
        estado.Add("Rondônia", "Porto Velho");
        estado.Add("Roraima", "Boa Vista");
        estado.Add("Sergipe", "Aracaju");
        estado.Add("Tocantins", "Palmas");


        Console.WriteLine(estado["Alagoas"]);
        Console.WriteLine(estado["Santa Catarina"]);
        Console.WriteLine(estado["Rio de Janeiro"]);
        }
    }
}
using System;


namespace ProjetoMotorDeCarro.Classes
{
    public class Carro
    {
        public int AnoDeFabricacao { get; set; }
        public string Marca { get; set; } = " ";
        public string Modelo { get; set; } = " ";
        public string Cor { get; set; } = " ";
        public Motor Motor { get; set; }

        public Carro(int anoDeFabricacao, string marca, string modelo, string cor, Motor motor)
        {
            AnoDeFabricacao = anoDeFabricacao;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Motor = motor;
        }

        public void ExibirInfomacoesTotais(){
            Console.WriteLine($"Carro: {Marca}, {Modelo}, {Cor}, {AnoDeFabricacao}");
            Console.WriteLine($"Potencia do motor: {Motor.Potencia}CV");
            Console.WriteLine($"Tipo de combústivel: {Motor.TipoCombustivel}");
        }


    }
}
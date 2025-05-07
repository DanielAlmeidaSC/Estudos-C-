namespace ProjetoRetornarCarros
{
    public class Carro
    {
        public string Marca { get; set; } = " ";
        public string Modelo { get; set; } = " ";
        public string Cor { get; set; } = " ";
        public int Ano { get; set; }


        public Carro(string marca, string modelo, string cor, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }    
        public void ImprimirInformacoes(){
            Console.WriteLine("Marca: "+Marca);
            Console.WriteLine("Modelo: "+Modelo);
            Console.WriteLine("Cor: "+Cor);
            Console.WriteLine("Ano: "+Ano);
        }
    }
}
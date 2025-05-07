namespace CalculosDeRetangulo
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public void CalcularArea(double largura, double altura)
        {
            double resultado = largura * altura;

            Console.WriteLine("Resultado da área do retangulo: {0}", resultado.ToString("F2"));
        }

        public void CalcularPerimetro(double largura, double altura)
        {
            double resultado = 2 *( largura + altura);

            Console.WriteLine("Resultado do perímetro do retangulo: {0}", resultado.ToString("F2"));
        }
    }
}
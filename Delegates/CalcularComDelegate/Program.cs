using System;

namespace CalcularComDelegate
{
    //Defina um delegate que aceite dois números inteiros e retorne um inteiro. Crie métodos para somar e multiplicar esses números. Use o delegate para chamar esses métodos.

    class Program
    {
        public delegate int EntradaDeDados(int x, int y);

        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {

            EntradaDeDados entradaDeDados; //Instancia o delegate que está apontando para todos os métodos

            entradaDeDados = Somar; //Agora está apontando para o método Somar apenas

            int resultado = Somar(2, 3);

            Console.WriteLine("Resultado: {0}", resultado);

            entradaDeDados = Multiplicar; //Está apontando para o método multiplicar

            resultado = entradaDeDados(2, 3); // dá certo utilizando o nome da variavel do delegate ou se quiser usar apenas o método estático
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
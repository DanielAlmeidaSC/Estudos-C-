using System;

namespace TransformarEmMaiuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "dAnIel";
            string nome2 = "nERCI";
            string nome3 = "JESUS";
            string nome4 = "braSIL";
            string nome5 = "uSA";
            string nome6 = "euRoPa";

            Console.WriteLine(nome1.Capitalize());
            Console.WriteLine(nome2.Capitalize());
            Console.WriteLine(nome3.Capitalize());
            Console.WriteLine(nome4.Capitalize());
            Console.WriteLine(nome5.Capitalize());
            Console.WriteLine(nome6.Capitalize());
        }
    }
}
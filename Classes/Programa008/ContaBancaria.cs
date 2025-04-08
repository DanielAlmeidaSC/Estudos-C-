using System;
using System.Globalization;

namespace Programa008 {
   class ContaBancaria{

        public string Titular;
        public double Saldo = 250.0;

        public void Depositar (double valor){
            double depositar = valor;

            Saldo = Saldo + depositar;

        }        
        public void Sacar(double valor){
            double sacar = valor;

            if(Saldo > valor){
                Saldo = Saldo - sacar;
            }else{
                Console.WriteLine("------------------------------");
                Console.WriteLine("******Saldo insuficiente*****");
                Console.WriteLine("------------------------------");
            }
        } 


        public void ExibirInformacoes(){
            Console.WriteLine("Titular: "+Titular);
            Console.WriteLine("Saldo: "+Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
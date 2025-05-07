using System;
using System.Globalization;

namespace ContaBancaria
{
    public class ContaBancaria
    {
        public string Titular { get; set; } = "";
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(String titular, int numeroDaConta)
        {
            Titular = titular;
            NumeroDaConta = numeroDaConta;
        }
        public void Depositar(double valor){
            Saldo += valor;
        }

        public void Sacar(double valor){
            if (Saldo < valor)
            {
                Console.WriteLine("Não é possível sacar o dinheiro! Saldo insuficiente!");
            }
            else{
                Saldo -= valor;
            }
        }

        public void SaldoAtual(){
            Console.WriteLine("Saldo: {0}", Saldo.ToString("C", new CultureInfo("pt-BR")));
        }


        public void ImprimirDados(){
            Console.WriteLine("Nome do titular: {0}", Titular);
            Console.WriteLine("Número da conta: {0}", NumeroDaConta);
            Console.WriteLine("Saldo: {0}", Saldo.ToString("C", new CultureInfo("pt-BR")));
        }
    }
}
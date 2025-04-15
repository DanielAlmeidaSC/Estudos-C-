using System;
using System.Globalization;

namespace Programa007
{
    class ContaBancaria
    {
        //Classe ContaBancaria com atributo saldo. Criar métodos para Depositar e Sacar, validando as operações.
        private double _saldo;

        public double Saldo { get{ return _saldo; } }

        public ContaBancaria(double saldo){
            _saldo = saldo;
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (_saldo >= valor){
                _saldo -= valor;
            }else{
                Console.WriteLine("O valor a ser sacado não pode ser maior que o disponível em conta-corrente!");
            }

        }

        public void Imprimir(){
            Console.WriteLine("Saldo = "+Saldo.ToString("F2", CultureInfo.InstalledUICulture));
        }

    }
}
using System;

namespace Programa004
{
    class Funcionario
    {
        //Classe Funcionario com atributo privado salario. Criar uma property que só permite modificar o salário se for maior que zero.
        private double _salario;

        public Funcionario(double salario){
            _salario = salario;
        }
        public double AlterarSalario
        {
            set
            {
                if (value > 0)
                {
                    _salario += value;
                }
            }
        }

        public double Salario{
            get{
                return _salario;
            }
        }
    }
}
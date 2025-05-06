using System;
using Enums;
namespace Classes
{
    public class TemPermissao
    {
        public static void EnterOrNot(int numeroDigitado)
        {
            NivelDeAcesso cargo = (NivelDeAcesso)numeroDigitado;

            if (numeroDigitado == 3)
            {
                Console.WriteLine("Você é um {0} e tem permissão para as seguintes funções: ", cargo);
                Console.WriteLine("*Visualizar Produtos*");
                Console.WriteLine("*Adicionar Produtos ao Carrinho*");
                Console.WriteLine("*Alterar Informações Pessoais do Cadastro*");
            }
            else if (numeroDigitado == 2)
            {
                Console.WriteLine("Você é um {0} e tem permissão para as seguintes funções: ", cargo);
                Console.WriteLine("*Gerenciar Estoque*");
                Console.WriteLine("*Visualizar Relatório De Vendas*");
                Console.WriteLine("*Aprovar Pedidos*");
            }
            else if(numeroDigitado == 1)
            {
                Console.WriteLine("Você é um {0} e tem permissão para as seguintes funções: ", cargo);
                Console.WriteLine("*Gerenciar Permissões de Acesso*");
                Console.WriteLine("*Alterar Configurações do Sistema*");
                Console.WriteLine("*Acessar Logs de Atividades*");
            }
            else
            {
                Console.WriteLine("Número digitado foge dos parâmetros pré-estabelecidos!");
            }
        }
    }
}
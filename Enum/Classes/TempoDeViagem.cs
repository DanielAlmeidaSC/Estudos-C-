using System;
using Enums;


namespace Classes
{
    public class TempoDeViagem
    {
        public static void RetornarTempoDeViagem(string tipoVeiculo, double distancia)
        {
            double tempoDeViagem;
            double velocidadeMedia;

            if (Enum.TryParse<ModoDeTransporte>(tipoVeiculo, true, out ModoDeTransporte veiculo))
            {
                if (veiculo == ModoDeTransporte.Caminhão)
                {
                    velocidadeMedia = 70.0d;

                    tempoDeViagem = distancia / velocidadeMedia;

                    Console.WriteLine("O tempo de viagem é de {0} horas com o veículo {1}", tempoDeViagem.ToString("F2"), veiculo);
                }
                else if (veiculo == ModoDeTransporte.Carro)
                {
                    velocidadeMedia = 100.0d;

                    tempoDeViagem = distancia / velocidadeMedia;

                    Console.WriteLine("O tempo de viagem é de {0} horas com o veículo {1}", tempoDeViagem.ToString("F2"), veiculo);
                }
                else if (veiculo == ModoDeTransporte.Bicicleta)
                {
                    velocidadeMedia = 20.0d;

                    tempoDeViagem = distancia / velocidadeMedia;

                    Console.WriteLine("O tempo de viagem é de {0} horas com o veículo {1}", tempoDeViagem.ToString("F2"), veiculo);
                }
                else if (veiculo == ModoDeTransporte.Avião)
                {
                    velocidadeMedia = 800.0d;

                    tempoDeViagem = distancia / velocidadeMedia;

                    Console.WriteLine("O tempo de viagem é de {0} horas com o veículo {1}", tempoDeViagem.ToString("F2"), veiculo);
                }

            }
            else
            {
                Console.WriteLine("Nome fora dos parâmetros pré-estabelecidos!");
            }


        }
    }
}
using System;
using Enums;


namespace Classes
{
    public class TempoConclusao
    {
        public static void RetornarTempoMaximo(int prioridadeDigitada){
            PrioridadeTarefa prioridade = (PrioridadeTarefa)prioridadeDigitada;

            if(prioridade == PrioridadeTarefa.Baixa){
                Console.WriteLine("O tempo máximo para a entrega da tarefa é de 72h");
            }
            else if(prioridade == PrioridadeTarefa.Média)
            {
                Console.WriteLine("O tempo máximo para a entrega da tarefa é de 48h");
            }
            else if(prioridade == PrioridadeTarefa.Alta)
            {
                Console.WriteLine("O tempo máximo para a entrega da tarefa é de 24h");
            }
        }        
    }
}
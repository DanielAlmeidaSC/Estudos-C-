namespace HerancaMultipla.Entities
{
    public class AlunoBolsista : Aluno
    {
        public override void MostrarInfo()
        {
            base.MostrarInfo(); //vai mostrar as duas bases genérica Pessoa e Aluno
            Console.WriteLine("Aluno bolsista Ariele Moellmann");
        }
    }
}
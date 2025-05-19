namespace HerancaMultipla.Entities
{
    public class Aluno : Pessoa
    {
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Aluno Daniel Almeida");
        }
    }
}
namespace VeiculoMover.Entities
{
    public class Carro : Veiculo
    {
        public override void Mover()
        {
            base.Mover();
            Console.WriteLine("Personalizado: O carro está se movendo!");
        }
    }
}
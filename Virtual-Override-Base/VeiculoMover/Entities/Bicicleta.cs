namespace VeiculoMover.Entities
{
    public class Bicicleta : Veiculo
    {
        public override void Mover()
        {
            base.Mover();
            Console.WriteLine("Personalizado: A bicicleta está se movendo");
        }
    }
}
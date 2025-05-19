namespace Animal.Entities
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            base.FazerSom();
            Console.WriteLine("Som personalizado: Au au!");
        }
    }
}
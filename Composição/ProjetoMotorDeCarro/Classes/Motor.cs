namespace ProjetoMotorDeCarro
{
    public class Motor
    {
        public int Potencia { get; set; }        
        public EnumTipoCombustivel TipoCombustivel { get; set; }
        

        public Motor(int potencia,EnumTipoCombustivel tipoCombustivel)
        {
            Potencia = potencia;
            TipoCombustivel = tipoCombustivel;
        }

        public void MostrarTipoCombustivel(){
            Console.WriteLine("Tipo de combustível: {0}", TipoCombustivel);
        }
        
    }
}
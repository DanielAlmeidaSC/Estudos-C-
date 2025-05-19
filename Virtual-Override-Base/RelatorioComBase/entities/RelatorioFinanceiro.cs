namespace RelatorioComBase.entities
{
    public class RelatorioFinanceiro : Relatorio
    {
        public override void Gerar()
        {
            base.Gerar();
            Console.WriteLine("Dados financeiros: ");
            Console.WriteLine("Quantia bruta faturada:  R$10.000.000,00");
            Console.WriteLine("Quantia líquida faturada:  R$6.000.000,00");
            Console.WriteLine("Gastos:  R$4.000.000,00");
        }
    }
}

namespace ProgramaContribuente.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica( string name, double rendaAnual,double gastoSaude) : base(name, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculoImposto()
        {
            double sum = 2000.00;
            if (RendaAnual >= sum)
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
            else 
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
        }
    }
}

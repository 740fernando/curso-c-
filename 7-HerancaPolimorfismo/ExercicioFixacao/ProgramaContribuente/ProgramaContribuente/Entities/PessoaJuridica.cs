

namespace ProgramaContribuente.Entities
{
    class PessoaJuridica:Contribuinte
    {
        public int Nfuncionarios { get; set; }

        public PessoaJuridica( string name, double rendaAnual, int nfuncionarios) :base(name,rendaAnual)
        {
            Nfuncionarios = nfuncionarios;
        }
        public override double CalculoImposto()
        {
            if(Nfuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}

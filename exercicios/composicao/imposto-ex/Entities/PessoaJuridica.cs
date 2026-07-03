namespace ImpostoEx.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public double NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, double numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (NumeroFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }
            
            return imposto;
        }

    }
}
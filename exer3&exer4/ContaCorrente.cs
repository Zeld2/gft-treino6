using exer3Eexer4;

namespace exer3
{
    public class ContaCorrente : Conta, Imposto
    {
        public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double RendimentoMensal()
        {
            return saldo * 0.03;
        }
        public double calcularImposto()
        {
            return RendimentoMensal() * 0.25;
        }
    }
}
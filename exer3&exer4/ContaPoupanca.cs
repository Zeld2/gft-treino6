using exer3Eexer4;

namespace exer3
{
    public class ContaPoupanca : Conta, Imposto
    {
        public ContaPoupanca(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double RendimentoMensal()
        {
            return saldo * 0.05;
        }

        public double calcularImposto()
        {
            return RendimentoMensal()*0.1;
        }
    }
}
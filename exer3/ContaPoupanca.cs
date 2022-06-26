namespace exer3
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double RendimentoMensal()
        {
            return saldo * 0.05;
        }
    }
}
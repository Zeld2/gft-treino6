namespace exer3
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double RendimentoMensal()
        {
            return saldo * 0.03;
        }
    }
}
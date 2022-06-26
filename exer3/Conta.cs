namespace exer3
{
    public abstract class Conta
    {
        protected string numero { get; set; }

        protected string titular { get; set; }

        protected double saldo { get; set; }
        

        public Conta(string numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public virtual double RendimentoMensal()
        {
            return 0; 
        }

        public override string ToString()
        {
            return ($"Número da conta: {numero} | Titular: {titular} | Saldo: R${saldo} | Rendimento mensal: R${RendimentoMensal()}");
        }

    }
}
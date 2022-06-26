namespace exer2
{
    public class Pessoa
    {
        private string Nome { get; set; }

        private string Endereco { get; set; }

        private string Telefone { get; set; }

        public Pessoa(string nome, string endereco, string telefone)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;

        }

        public override string ToString()
        {
            return Nome + " | " + Endereco + " | " + Telefone;
        }

    }
}
namespace ex_7.src
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base (nome, idade, salario)
        {

        }
        public override double Bonificacao()
        {
            return this.salario + 3000;
        }
    }
}
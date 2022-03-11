namespace ex_7.src
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base (nome, idade, salario)
        {

        }
        public override double Bonificacao()
        {
            return this.salario + 10000;
        }

    }
}
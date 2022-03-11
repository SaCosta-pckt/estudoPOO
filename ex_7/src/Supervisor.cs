namespace ex_7.src
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base (nome, idade, salario)
        {

        }
        public override double Bonificacao()
        {
            return this.salario + 5000;
        }
    }
}
namespace ex_7.src
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, int salario) : base (nome, idade, salario)
        {

        }
        public override float Bonificacao()
        {
            return this.salario + 5000;
        }
    }
}
namespace ex_7.src
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, int salario) : base (nome, idade, salario)
        {

        }
        public override float Bonificacao()
        {
            return this.salario + 10000;
        }

    }
}
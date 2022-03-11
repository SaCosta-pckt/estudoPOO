namespace ex_7.src
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, int salario) : base (nome, idade, salario)
        {

        }
        public override float Bonificacao()
        {
            return this.salario + 3000;
        }
    }
}
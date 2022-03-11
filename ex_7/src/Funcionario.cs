namespace ex_7.src
{
    public class Funcionario
    {
        public Funcionario(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        protected string nome { get; set; }
        protected int idade { get; set; }
        protected double salario { get; set; }
    
        public virtual double Bonificacao(){
            return this.salario;
        }
    }
}
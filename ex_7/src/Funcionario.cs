namespace ex_7.src
{
    public class Funcionario
    {
        public Funcionario(string nome, int idade, int salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        protected string nome { get; set; }
        protected int idade { get; set; }
        protected float salario { get; set; }
    
        public virtual float Bonificacao(){
            return this.salario;
        }
    }
}
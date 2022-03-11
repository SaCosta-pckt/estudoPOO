namespace ex_2.src.Abstratos
{
    public abstract class Produto
    {
        protected Produto()
        {
        }

        protected Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        protected string nome { get; set; }
        protected double preco { get; set; }
        protected int qtd { get; set; }

        public string GetNome(){
            return this.nome;
        }

        public double GetPreco(){
            return this.preco;
        }

        public int GetQtd(){
            return this.qtd;
        }
        
    }
}
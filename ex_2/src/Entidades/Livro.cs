using ex_2.src.Abstratos;
using ex_2.src.Interfaces;
using System;

namespace ex_2.src.Entidades
{
    public class Livro : Produto, Imposto
    {
        public Livro()
        {
        }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        private string autor { get; set; }
        private string tema { get; set; }
        private int qtdPag { get; set; }

        public double CalculaImposto(){
            if(this.tema == "educativo"){
                return 0;
            }
            else{
                return this.preco * 0.10;
            } 
         }
    }
}
using ex_2.src.Abstratos;
using ex_2.src.Interfaces;
using System;

namespace ex_2.src.Entidades
{
    public class VideoGame : Produto, Imposto
    {
        public VideoGame()
        {
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        private string marca { get; set; }
        private string modelo { get; set; }
        private bool isUsado { get; set; }

        public double CalculaImposto(){
            if(this.isUsado == true){
                return this.preco*0.25;
            }
            else{
                return this.preco*0.45;
            } 
         }
        
    }
}
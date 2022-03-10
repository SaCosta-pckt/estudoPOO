using System;
namespace ex_3.src
{
    public class Personagem
    {
        public Personagem()
        {
            Personagem.qtdPersonagens++;
            this.contagem = Personagem.qtdPersonagens;
        }
        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca)
        {
            this.nome = nome;
            this.vida = vida;
            this.mana = mana;
            this.xp = xp;
            this.inteligencia = inteligencia;
            this.forca = forca;

            Personagem.qtdPersonagens++;
            this.contagem = Personagem.qtdPersonagens;
        }

        private static int qtdPersonagens = 0;

        protected int contagem { get; set; }
        protected string nome { get; set; } = "";
        protected int vida { get; set; }
        protected int mana { get; set; }
        protected float xp { get; set; }
        protected int inteligencia { get; set; }
        protected int forca { get; set; }
        protected int level { get; set; } = 1;

        public virtual void LvlUp(){

        }

        public void ContagemPersonagens(){
            Console.WriteLine("Personagens criados: " + (this.contagem -1));
        }

        

    }
}
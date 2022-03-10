using System;
using System.Collections.Generic;
namespace ex_3.src
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca) : base(nome, vida, mana, xp, inteligencia, forca)
        {
        }

        private List <string> habilidades { get; set; } = new List<string>();

        public override void LvlUp(){
            this.vida += 500;
            this.mana += 80;
            this.xp += 50;
            this.inteligencia += 5;
            this.forca += 10;
            this.level += 1;
            Console.WriteLine($"{this.nome} subiu de nível!");
        }  

        public void Attack(){
            Random r = new Random();
            int dano = this.forca * this.level + r.Next(0, 300);;
            Console.WriteLine($"{this.nome} atacou causando um {dano} de dano!");
        }

        public void AprenderHabilidade(string habilidade){
            this.habilidades.Add(habilidade);
            Console.WriteLine($"{this.nome} aprendeu {habilidade}!");
        }
    }
}
using System;
using System.Collections.Generic;
namespace ex_3.src
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca) : base(nome, vida, mana, xp, inteligencia, forca)
        {
            
        }

        private List <string> magias { get; set; } = new List<string>();

        public override void LvlUp(){
            this.vida += 200;
            this.mana += 100;
            this.xp += 50;
            this.inteligencia += 10;
            this.forca += 5;
            this.level += 1;
            Console.WriteLine($"{this.nome} subiu de nível!");
        }

        public void Attack(){
            Random r = new Random();
            int dano = this.inteligencia * this.level + r.Next(0, 300);;
            Console.WriteLine($"{this.nome} atacou causando um {dano} de dano!");

        }

        public void AprenderMagia(string magia){
            this.magias.Add(magia);
            Console.WriteLine($"{this.nome} aprendeu {magia}!");
        }


        
    }
}
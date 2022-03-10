using System;
using System.Collections.Generic;
using static System.Console;
using ex_3.src;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtor:  int vida, int mana, float xp, int inteligencia, int forca, int level
            Guerreiro g_heroi1 = new Guerreiro("Geraldo", 500, 200, 100, 5, 15);
            g_heroi1.LvlUp();
            g_heroi1.Attack();
            g_heroi1.AprenderHabilidade("Corte ultra Rápido: Tramontina");

            WriteLine();
            Mago m_heroi2 = new Mago("Jennifer", 200, 500, 100, 15, 5);
            m_heroi2.LvlUp();
            m_heroi2.Attack();
            m_heroi2.AprenderMagia("Som super sônico: Falsete de Melody");
            
            WriteLine();
            Personagem p1 = new Personagem();
            p1.ContagemPersonagens();
            
        }
    }
}

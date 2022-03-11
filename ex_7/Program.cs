using System;
using  static System.Console;
using ex_7.src;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente("Rogério", 52, 7000.50);
            Supervisor s1 = new Supervisor("Amanda", 40, 3500);
            Vendedor v1 = new Vendedor("Paula", 33, 2000.80);

            WriteLine("Bonificação do Gerente: " + g1.Bonificacao());
            WriteLine("Bonificação do Supervisor: " + s1.Bonificacao());
            WriteLine("Bonificação do Vendedor: " + v1.Bonificacao());
        }
    }
}

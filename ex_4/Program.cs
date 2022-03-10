using System;
using static System.Console;
using System.Collections.Generic;
using ex_4.src;
using System.Linq;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atividade 4
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);


            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            PessoaVelha(pessoas);

            //Atividade 5
            ExcluirMenores(pessoas);

            //Atividade 6
            VerificarExistencia("Jessica", pessoas);





        }

        private static void PessoaVelha(List<Pessoa> pessoas)
        {
            //Atribuição por referência
            Pessoa maisVelho = pessoas.OrderByDescending(pessoa => pessoa.idade).ToList()[0];
            WriteLine("A Pessoa mais velha: " + maisVelho.nome);

        }

        private static void ExcluirMenores(List<Pessoa> pessoas)
        {
            WriteLine("\nQuantidade antes exclusão dos menores de idade: " + pessoas.Count);
            foreach (var pessoa in pessoas.ToList())
            {
                if (pessoa.idade < 18)
                {
                    pessoas.Remove(pessoa);
                }
            }

            WriteLine("Quantidade depois da exclusão dos menores de idade: " + pessoas.Count);
        }

        private static void VerificarExistencia(string nome, List<Pessoa>pessoas)
        {
            //vefificar se está na lista e exibir a idade
            int cont = 0;
            foreach (var pessoa in pessoas)
            {
                if (pessoa.nome == nome)
                {
                    WriteLine($"{nome} está na lista, idade: {pessoa.idade}");
                    cont ++;
                }
            }
            if (cont == 0)
            {
                WriteLine("Nenhuma pessoa com este nome foi encontrada.");
            }

        }
    }
}

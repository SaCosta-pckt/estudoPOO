using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace ex_2.src.Entidades
{
    public class Loja
    {
        public Loja()
        {
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        private string nome { get; set; }
        private string cnpj { get; set; }

        private List <Livro> livros { get; set; } = new List<Livro> ();
        private List <VideoGame> videoGames { get; set; } = new List<VideoGame> ();

        public void ListaLivros(){
            if ((livros!= null) || (!livros.Any())){ // se a lista estiver nula ou vazia
                WriteLine("--------------------------------------------------------------------");
                WriteLine($"A loja {this.nome} possui estes livros para a venda:");
                foreach (var livro in livros)
                {
                    WriteLine($"Título: {livro.GetNome()}, preço: {livro.GetPreco()}, quantidade: {livro.GetQtd()} em estoque.");
                }
            }
            else{
                WriteLine("--------------------------------------------------------------------");
                WriteLine($"A loja não tem livros no seu estoque.");
            }

        }

        public void ListaVideoGames(){
            if ((videoGames!= null) || (!videoGames.Any())){ // se a lista estiver nula ou vazia
                WriteLine("--------------------------------------------------------------------");
                WriteLine($"A loja {this.nome} possui estes video-games para a venda:");
                foreach (var videoGame in videoGames)
                {
                    WriteLine($"Título: {videoGame.GetNome()}, preço: {videoGame.GetPreco()}, quantidade: {videoGame.GetQtd()} em estoque.");
                }
            }
            else{
                WriteLine("--------------------------------------------------------------------");
                WriteLine($"A loja não tem video-games no seu estoque.");
            }

        }

        public double CalculaPatrimonio(){
            double soma = 0;
            foreach (var videoGame in videoGames)
                {
                    soma += videoGame.GetPreco() * videoGame.GetQtd();  
                }
            foreach (var livro in livros)
                {
                    soma += livro.GetPreco() * livro.GetQtd();
                }
            return soma;
        }




        
    }
}
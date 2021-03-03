using System;
using System.Collections.Generic;
using ExProdutos.Domain.Services;

namespace ExProdutos.Domain.Entities
{
    public class Loja : ILista, IPatrimonio
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja() { }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }

        public void listaVideoGames(List<VideoGame> videoGames)
        {
            if (videoGames.Count < 1) {
                throw new ArgumentException("A lista de video games está inválida");
            }

            foreach (VideoGame list in videoGames) {
                Console.WriteLine(list.Nome + ", " + list.Preco + ", " + list.Quantidade);
            }
        }

        public void listaLivros(List<Livro> livros)
        {
            if (livros.Count < 1) {
                throw new ArgumentException("A lista de livros está inválida");
            }

            foreach (Livro lista in livros) {
                Console.WriteLine(lista.Nome + ", " + lista.Preco + ", " + lista.Quantidade);
            }
        }

        public double calculaPatrimonio(List<Livro> livro, List<VideoGame> game)
        {
            double calculoLivro = 0;
            double calculoVideoGame = 0;

            if (livro.Count < 1) {
                throw new ArgumentException("Lista de livros inválida");
            }

            if (game.Count < 1) {
                throw new ArgumentException("Lista de games inválida");
            }

            foreach (Livro list in livro) {
                calculoLivro += list.Preco * list.Quantidade;
            }

            foreach (VideoGame videogame in game) {
                calculoVideoGame += videogame.Preco * videogame.Quantidade;
            }

            double calculoTotal;
            calculoTotal = calculoVideoGame + calculoLivro;

            return calculoTotal;
        }
    }
}
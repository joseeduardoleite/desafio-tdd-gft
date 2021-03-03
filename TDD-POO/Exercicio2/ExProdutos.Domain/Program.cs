using System;
using System.Collections.Generic;
using System.Globalization;
using ExProdutos.Domain.Entities;

namespace ExProdutos.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "Tolkien", "fantasia", 500);
            Livro l3 = new Livro(".NET POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps5 = new VideoGame("PS5", 1800, 100, "Sony", "Slim", false);
            VideoGame ps5Usado = new VideoGame("PS5", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps5);
            games.Add(ps5Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "1234", livros, games);

            americanas.listaLivros(livros);
            Console.WriteLine();
            americanas.listaVideoGames(games);
            Console.WriteLine();

            Console.WriteLine("Imposto sobre livro 1:");
            Console.WriteLine(l1.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Imposto sobre livro 2:");
            Console.WriteLine(l2.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Imposto sobre livro 3:");
            Console.WriteLine(l3.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Imposto sobre Videogame 1:");
            Console.WriteLine(ps5.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Imposto sobre Videogame 2:");
            Console.WriteLine(ps5Usado.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Imposto sobre Videogame 3:");
            Console.WriteLine(ps5Usado.calculaImposto().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(americanas.calculaPatrimonio(livros, games).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

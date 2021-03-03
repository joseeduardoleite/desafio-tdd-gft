using System;
using System.Collections.Generic;
using ExProdutos.Domain.Entities;
using ExProdutos.Test.Util;
using Xunit;

namespace ExProdutos.Test.Produtos
{
    public class ProdutoTest
    {
        private readonly string _nomeLivro;
        private readonly double _precoLivro;
        private readonly int _quantidadeLivro;
        private readonly string _autor;
        private readonly string _tema;
        private readonly int _quantidadePaga;

        private readonly string _nomeVideoGame;
        private readonly double _precoVideoGame;
        private readonly int _quantidadeVideoGame;
        private readonly string _marca;
        private readonly string _modelo;
        private readonly bool _isUsado;

        private readonly string _nomeLoja;
        private readonly string _cnpj;


        public ProdutoTest()
        {
            _nomeLivro = "O Codificador Limpo";
            _precoLivro = 100.0;
            _quantidadeLivro = 5;
            _autor = "Robert C. Martin";
            _tema = "Programação";
            _quantidadePaga = 150;

            _nomeVideoGame = "Xbox";
            _precoVideoGame = 1800.0;
            _quantidadeVideoGame = 10;
            _marca = "Microsoft";
            _modelo = "One";
            _isUsado = false;

            _nomeLoja = "Malikoski";
            _cnpj = "1234567/0001-77";
        }

        [Fact]
        public void Deve_criar_um_livro()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);

            Assert.NotNull(livro);
        }

        [Fact]
        public void Deve_criar_um_video_game()
        {
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            Assert.NotNull(videoGame);
        }

        [Fact]
        public void Deve_criar_uma_loja()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            List<Livro> listLivro = new List<Livro>();
            listLivro.Add(livro);

            List<VideoGame> listVideoGame = new List<VideoGame>();
            listVideoGame.Add(videoGame);

            var loja = new Loja(_nomeLoja, _cnpj, listLivro, listVideoGame);

            Assert.NotNull(loja);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_calcular_imposto_de_livro_se_tema_invalido(string temaInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, temaInvalido, _quantidadePaga).calculaImposto())
                                                .ComMensagem("Tema inválido para calcular imposto");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_calcular_imposto_de_livro_se_preco_invalido(double precoInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Livro(_nomeLivro, precoInvalido, _quantidadeLivro, _autor, _tema, _quantidadePaga).calculaImposto())
                                                .ComMensagem("Preço inválido para calcular imposto");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_calcular_imposto_de_video_game_se_preco_invalido(double precoInvalido)
        {
            Assert.Throws<ArgumentException>(() => new VideoGame(_nomeVideoGame, precoInvalido, _quantidadeVideoGame, _marca, _modelo, _isUsado).calculaImposto())
                                                .ComMensagem("Preço inválido para calcular imposto");
        }

        [Fact]
        public void Nao_deve_loja_listar_video_games_invalidos()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);

            List<Livro> listLivro = new List<Livro>();
            listLivro.Add(livro);

            List<VideoGame> listVideoGameInvalido = new List<VideoGame>();

            var loja = new Loja(_nomeLoja, _cnpj, listLivro, listVideoGameInvalido);

            Assert.Throws<ArgumentException>(() => new Loja(loja.Nome, loja.Cnpj, listLivro, listVideoGameInvalido).listaVideoGames(listVideoGameInvalido))
                                                .ComMensagem("A lista de video games está inválida");
        }

        [Fact]
        public void Nao_deve_loja_listar_livros_invalidos()
        {
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            List<VideoGame> listVideoGame = new List<VideoGame>();
            listVideoGame.Add(videoGame);

            List<Livro> listLivroInvalido = new List<Livro>();

            var loja = new Loja(_nomeLoja, _cnpj, listLivroInvalido, listVideoGame);

            Assert.Throws<ArgumentException>(() => new Loja(loja.Nome, loja.Cnpj, listLivroInvalido, listVideoGame).listaLivros(listLivroInvalido))
                                                .ComMensagem("A lista de livros está inválida");
        }

        [Fact]
        public void Nao_deve_loja_calcular_patrimonio_com_livros_invalidos()
        {
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            List<VideoGame> listVideoGame = new List<VideoGame>();
            listVideoGame.Add(videoGame);

            List<Livro> listLivroInvalido = new List<Livro>();

            var loja = new Loja(_nomeLoja, _cnpj, listLivroInvalido, listVideoGame);

            Assert.Throws<ArgumentException>(() => new Loja(loja.Nome, loja.Cnpj, listLivroInvalido, listVideoGame).calculaPatrimonio(listLivroInvalido, listVideoGame))
                                                .ComMensagem("Lista de livros inválida");
        }

        [Fact]
        public void Nao_deve_loja_calcular_patrimonio_com_video_games_invalidos()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);

            List<Livro> listLivro = new List<Livro>();
            listLivro.Add(livro);

            List<VideoGame> listVideoGameInvalido = new List<VideoGame>();

            var loja = new Loja(_nomeLoja, _cnpj, listLivro, listVideoGameInvalido);

            Assert.Throws<ArgumentException>(() => new Loja(loja.Nome, loja.Cnpj, listLivro, listVideoGameInvalido).calculaPatrimonio(listLivro, listVideoGameInvalido))
                                                .ComMensagem("Lista de games inválida");
        }
    }
}

using System;
using JokenPo.Domain.Entities;
using JokenPo.Domain.Entities.Enums;
using JokenPo.Test.Util;
using Xunit;

namespace JokenPo.Test.Partidas
{
    public class PartidaTest
    {
        private readonly string _nome;

        public PartidaTest()
        {
            _nome = "Malikoski";
        }

        [Fact]
        public void Deve_criar_uma_partida()
        {
            var partida = new Partida();

            Assert.NotNull(partida);
        }

        [Fact]
        public void Deve_criar_um_jogador()
        {
            var jogador = new Jogador(_nome);

            Assert.NotNull(jogador);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_selecionar_opcao_se_nome_jogador_invalido(string nomeInvalido)
        {
            var jogadorInvalido = new Jogador(nomeInvalido);
            var partida = new Partida();

            Assert.Throws<ArgumentException>(() => partida.SelecionarOpcao(jogadorInvalido))
                                                .ComMensagem("Nome do jogador inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_selecionar_opcao_se_opcao_jogador_invalida(int opcaoInvalida)
        {
            var jogador = new Jogador(_nome);
            jogador.Opcao = (Opcoes)opcaoInvalida;

            var partida = new Partida();

            Assert.Throws<ArgumentException>(() => partida.SelecionarOpcao(jogador))
                                                .ComMensagem("Opção inválida");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_vencer_ou_perder_se_nome_jogadores_invalidos(string nomeInvalido)
        {
            var jogadorInvalido1 = new Jogador(nomeInvalido);
            var jogadorInvalido2 = new Jogador(nomeInvalido);

            var partida = new Partida();

            Assert.Throws<ArgumentException>(() => partida.VencerOuPerder(jogadorInvalido1, jogadorInvalido2))
                                                .ComMensagem("Nome dos jogadores inválidos");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_vencer_ou_perder_se_opcao_jogadores_invalidas(int opcaoInvalida)
        {
            var jogadorInvalido1 = new Jogador(_nome);
            jogadorInvalido1.Opcao = (Opcoes)opcaoInvalida;

            var jogadorInvalido2 = new Jogador(_nome);
            jogadorInvalido2.Opcao = (Opcoes)opcaoInvalida;

            var partida = new Partida();
            
            Assert.Throws<ArgumentException>(() => partida.VencerOuPerder(jogadorInvalido1, jogadorInvalido2))
                                                .ComMensagem("Opção inválida");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_quantidade_vitorias_se_nome_jogadores_invalidos(string nomeInvalido)
        {
            var jogadorInvalido1 = new Jogador(nomeInvalido);

            var jogadorInvalido2 = new Jogador(nomeInvalido);

            var partida = new Partida();

            Assert.Throws<ArgumentException>(() => partida.quantidadeVitorias(jogadorInvalido1, jogadorInvalido2))
                                                .ComMensagem("Nome dos jogadores inválidos");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        public void Nao_deve_quantidade_vitorias_se_quantidade_vitorias_jogadores_invalidas(int quantidadeVitoriasInvalidas)
        {
            var jogadorInvalido1 = new Jogador(_nome);
            jogadorInvalido1.QuantidadeVitoria = quantidadeVitoriasInvalidas;

            var jogadorInvalido2 = new Jogador(_nome);
            jogadorInvalido2.QuantidadeVitoria = quantidadeVitoriasInvalidas;

            var partida = new Partida();

            Assert.Throws<ArgumentException>(() => partida.quantidadeVitorias(jogadorInvalido1, jogadorInvalido2))
                                                .ComMensagem("Quantidade de vitórias dos jogadores inválidas");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        public void Nao_deve_quantidade_empates_se_quantidade_empates_jogadores_invalidos(int quantidadeEmpatesInvalidos)
        {
            var partida = new Partida();
            partida.QuantidadeEmpates = quantidadeEmpatesInvalidos;

            Assert.Throws<ArgumentException>(() => partida.quantidadeEmpates(partida))
                                                .ComMensagem("Quantidade de empates dos jogadores inválidos");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        public void Nao_deve_quantidade_partidas_se_quantidade_partidas_jogadores_invalidas(int quantidadePartidasInvalidas)
        {
            var partida = new Partida();
            partida.QuantidadePartidas = quantidadePartidasInvalidas;

            Assert.Throws<ArgumentException>(() => partida.quantidadePartidas(partida))
                                                .ComMensagem("Quantidade de partidas dos jogadores inválidas");
        }
    }
}
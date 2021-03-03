using Xunit;
using ExVeiculos.Domain.Entities;
using System;
using ExVeiculos.Test.Util;

namespace ExVeiculos.Test.Veiculos
{
    public class VeiculoTest
    {
        private  readonly string _marca;
        private readonly string _modelo;
        private  readonly string _placa;
        private  readonly string _cor;
        private  readonly double _km;
        private  readonly bool _isLigado;
        private  readonly int _litrosCombustivel;
        private  readonly double _velocidade;
        private  readonly double _preco;

        public VeiculoTest()
        {
            _marca = "Mercedes";
            _modelo = "C63 AMG";
            _cor = "Preto";
            _km = 50000.0;
            _isLigado = false;
            _litrosCombustivel = 200;
            _velocidade = 300.0;
            _preco = 1000000.0;
        }

        [Fact]
        public void Deve_criar_veiculo()
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, _isLigado, _litrosCombustivel, _velocidade, _preco);

            Assert.NotNull(veiculo);
        }

        [Theory]
        [InlineData(false)]
        public void Nao_deve_acelerar_veiculo_desligado(bool isLigadoFalse)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, isLigadoFalse, _litrosCombustivel, _velocidade, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Acelerar())
                                                .ComMensagem("Você não pode acelerar com o carro desligado");
        }

        [Theory]
        [InlineData(70)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Nao_deve_abastecer_veiculo_acima_do_limite_de_combustivel(int limiteCombustivelInvalido)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, _isLigado, _litrosCombustivel, _velocidade, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Abastecer(limiteCombustivelInvalido))
                                                .ComMensagem("Excedeu o limite da quantidade de combustível");
        }

        [Theory]
        [InlineData(false)]
        public void Nao_deve_frear_veiculo_desligado(bool isLigadoFalse)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, isLigadoFalse, _litrosCombustivel, _velocidade, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Frear())
                                                .ComMensagem("Não foi possível frear!");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_frear_veiculo_com_velocidade_0(double velocidadeInvalida)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, _isLigado, _litrosCombustivel, velocidadeInvalida, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Frear())
                                                .ComMensagem("Não foi possível frear!");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_pintar_veiculo_com_cor_invalida(string corInvalida)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, corInvalida, _km, _isLigado, _litrosCombustivel, _velocidade, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Pintar(corInvalida))
                                                .ComMensagem("Cor inválida");
        }

        [Theory]
        [InlineData(true)]
        public void Nao_deve_ligar_veiculo_estando_ligado(bool isLigadoTrue)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, isLigadoTrue, _litrosCombustivel, _velocidade, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Ligar())
                                                .ComMensagem("O carro já está ligado!");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(50)]
        [InlineData(300)]
        public void Nao_deve_desligar_veiculo_com_velocidade_acima_de_0(double velocidadeInvalida)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, _isLigado, _litrosCombustivel, velocidadeInvalida, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Desligar())
                                                .ComMensagem("Não é possível desligar o carro em movimento");
        }

        [Theory]
        [InlineData(false)]
        public void Nao_deve_desligar_veiculo_ja_desligado(bool isLigadoFalse)
        {
            var veiculo = new Veiculo(_marca, _modelo, _placa, _cor, _km, isLigadoFalse, _litrosCombustivel, 0, _preco);

            Assert.Throws<ArgumentException>(() => veiculo.Desligar())
                                                .ComMensagem("O carro já está desligado");
        }
    }
}
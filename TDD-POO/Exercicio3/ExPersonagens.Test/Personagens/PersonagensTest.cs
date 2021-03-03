using System;
using System.Collections.Generic;
using ExPersonagens.Domain.Entities;
using ExPersonagens.Test.Util;
using Xunit;

namespace ExPersonagens.Test.Personagens
{
    public class PersonagensTest
    {
        private readonly string _nome;
        private readonly int _vida;
        private readonly int _mana;
        private readonly float _xp;
        private readonly int _inteligencia;
        private readonly int _forca;
        private readonly int _level;

        public PersonagensTest()
        {
            _nome = "Malikoski";
            _vida = 100;
            _mana = 200;
            _xp = 350;
            _inteligencia = 600;
            _forca = 800;
            _level = 300;
        }

        [Fact]
        public void Deve_criar_um_guerreiro()
        {
            var guerreiro = new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>());

            Assert.NotNull(guerreiro);
        }

        [Fact]
        public void Deve_criar_um_mago()
        {
            var mago = new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>());

            Assert.NotNull(mago);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_guerreiro_subir_de_lvl_se_lvl_invalido(int levelInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, levelInvalido, new List<string>()).lvlUp())
                                    .ComMensagem("Level inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_guerreiro_atacar_se_ataque_invalido(double ataqueInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>()).Attack(ataqueInvalido))
                                    .ComMensagem("Ataque inválido");
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_guerreiro_aprender_habilidade_se_habilidade_invalida(string habilidadeInvalida)
        {
            Assert.Throws<ArgumentException>(() => new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>()).aprenderHabilidade(habilidadeInvalida))
                                    .ComMensagem("Habilidade inválida");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_mago_subir_de_lvl_se_lvl_invalido(int levelInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, levelInvalido, new List<string>()).lvlUp())
                                    .ComMensagem("Level inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_mago_atacar_se_ataque_invalido(double ataqueInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>()).Attack(ataqueInvalido))
                                    .ComMensagem("Ataque inválido");
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_deve_mago_aprender_magia_se_magia_invalida(string magiaInvalida)
        {
            Assert.Throws<ArgumentException>(() => new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, new List<string>()).aprenderMagia(magiaInvalida))
                                    .ComMensagem("Magia inválida");
        }
    }
}
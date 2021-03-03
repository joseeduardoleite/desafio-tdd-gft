using System.Collections.Generic;
using FizzBuzz.Domain.Entities;
using Xunit;

namespace FizzBuzz.Test.FizzBuzzs
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Deve_criar_um_fizz_buzz()
        {
            List<string> lista = new List<string>();

            var fizz = new FizzBuzzProgram(lista);

            Assert.NotNull(fizz);
        }

        [Fact]
        public void Deve_executar_se_tamanho_lista_valido()
        {
            List<string> lista = new List<string>();

            var fizz = new FizzBuzzProgram(lista);

            fizz.Executar(lista);

            Assert.True(lista.Count <= 100);
        }

        [Fact]
        public void Deve_listar_se_tamanho_lista_valido()
        {
            List<string> lista = new List<string>();

            var fizz = new FizzBuzzProgram(lista);

            fizz.Listar(lista);

            Assert.True(lista.Count <= 100);
        }
    }
}
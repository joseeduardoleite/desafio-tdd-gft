using System;
using ExFuncionarios.Domain.Entities;
using ExFuncionarios.Test.Util;
using Xunit;

namespace ExFuncionarios.Test.Funcionarios
{
    public class FuncionarioTest
    {
        private readonly string _nome;
        private readonly int _idade;
        private readonly double _salario;

        public FuncionarioTest()
        {
            _nome = "Eduardo";
            _idade = 19;
            _salario = 3000.0;
        }
        [Fact]
        public void Deve_criar_um_gerente()
        {
            var gerente = new Gerente(_nome, _idade, _salario);

            Assert.NotNull(gerente);
        }

        [Fact]
        public void Deve_criar_um_supervisor()
        {
            var supervisor = new Gerente(_nome, _idade, _salario);

            Assert.NotNull(supervisor);
        }

        [Fact]
        public void Deve_criar_um_vendedor()
        {
            var vendedor = new Vendedor(_nome, _idade, _salario);

            Assert.NotNull(vendedor);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_gerente_adicionar_bonificacao_se_salario_invalido(double salarioInvalido)
        {
            var gerente = new Gerente(_nome, _idade, salarioInvalido);

            Assert.Throws<ArgumentException>(() => gerente.bonificacao())
                                                .ComMensagem("Salário inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_supervisor_adicionar_bonificacao_se_salario_invalido(double salarioInvalido)
        {
            var supervisor = new Supervisor(_nome, _idade, salarioInvalido);

            Assert.Throws<ArgumentException>(() => supervisor.bonificacao())
                                                .ComMensagem("Salário inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Nao_deve_vendedor_adicionar_bonificacao_se_salario_invalido(double salarioInvalido)
        {
            var vendedor = new Vendedor(_nome, _idade, salarioInvalido);
            
            Assert.Throws<ArgumentException>(() => vendedor.bonificacao())
                                                .ComMensagem("Salário inválido");
        }
    }
}
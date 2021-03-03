using System;

namespace ExFuncionarios.Domain.Entities
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            if (Salario < 1)
                throw new ArgumentException("Salário inválido");
            
            Salario += 10000.00;
        }
    }
}
using System;

namespace ExFuncionarios.Domain.Entities
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            if (Salario < 1)
                throw new ArgumentException("Salário inválido");
            
            Salario += 3000.00;
        }
    }
}
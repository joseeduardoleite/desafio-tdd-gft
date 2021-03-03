using System;

namespace ExFuncionarios.Domain.Entities
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            if (Salario < 1)
                throw new ArgumentException("Salário inválido");
            
            Salario += 5000.00;
        }
    }
}
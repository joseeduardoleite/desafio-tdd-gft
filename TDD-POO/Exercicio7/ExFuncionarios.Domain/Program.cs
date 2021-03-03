using System;
using ExFuncionarios.Domain.Entities;

namespace ExFuncionarios.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerentes = new Gerente("Jose Eduardo", 19, 10000);
            Funcionario supervisor = new Supervisor("Edu", 30, 5000);
            Funcionario vendedor = new Vendedor("Jeff Bezos", 30, 7000);

            gerentes.bonificacao();
            supervisor.bonificacao();
            vendedor.bonificacao();

            Console.WriteLine("Dados atualizados!");
            Console.Write("Salario gerente: ");
            Console.WriteLine(gerentes.Salario);
            Console.Write("Salario supervisor: ");
            Console.WriteLine(supervisor.Salario);
            Console.Write("Salario vendedor: ");
            Console.WriteLine(vendedor.Salario);
        }
    }
}

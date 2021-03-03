using System.Collections.Generic;
using FizzBuzz.Domain.Entities;

namespace FizzBuzz.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            var fizzBuzz = new FizzBuzzProgram(lista);

            fizzBuzz.Executar(lista);
            fizzBuzz.Listar(lista);
        }
    }
}

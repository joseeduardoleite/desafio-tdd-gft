using System;
using System.Collections.Generic;

namespace FizzBuzz.Domain.Entities
{
    public class FizzBuzzProgram
    {
        public List<string> Lista { get; set; }

        public FizzBuzzProgram(List<string> lista)
        {
            Lista = lista;
        }

        public void Executar(List<string> lista)
        {
            int j = 0;
            
            for (int i = 1; i <= 100; i++) {
                lista.Add(i.ToString());

                if (i % 3 == 0) {
                    lista[j] = "Fizz";
                }

                if (i % 5 == 0) {
                    lista[j] = "Buzz";
                }

                if (i % 3 == 0 && i % 5 == 0) {
                    lista[j] = "FizzBuzz";
                }

                j++;
            }
        }

        public void Listar(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
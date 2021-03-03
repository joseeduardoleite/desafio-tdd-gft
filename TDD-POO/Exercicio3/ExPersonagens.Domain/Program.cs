using System;
using System.Collections.Generic;
using ExPersonagens.Domain.Entities;

namespace ExPersonagens.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guerreiro> guerreiros = new List<Guerreiro>();
            List<Mago> magos = new List<Mago>();
            Guerreiro guerreiroAlfa = new Guerreiro("Arnold", 100, 100, 1000, 70, 300, 65, new List<string>());
            Mago magoAlfa = new Mago("Witcher", 100, 100, 1000, 70, 300, 65, new List<string>());

            System.Console.WriteLine("Nome do guerreiro: ");
            guerreiroAlfa.Nome = Console.ReadLine();

            System.Console.WriteLine("Nome do mago: ");
            magoAlfa.Nome = Console.ReadLine();
            System.Console.WriteLine();

            magoAlfa.lvlUp();
            guerreiroAlfa.lvlUp();

            double attackGuerreiro = 150;
            guerreiroAlfa.Attack(attackGuerreiro);
            double attackMago = 100;
            magoAlfa.Attack(attackMago);

            guerreiros.Add(guerreiroAlfa);
            magos.Add(magoAlfa);
            
            int countGuerreiro = 0;
            foreach (Personagem item in guerreiros) {
                countGuerreiro++;
            }

            int countMago = 0;
            foreach (Personagem item in magos) {
                countMago++;
            }

            int somaCount = countGuerreiro + countMago;

            Console.Clear();

            Console.WriteLine("Dados dos guerreiros:");
            Console.WriteLine("Nome guerreiro:");
            Console.WriteLine(guerreiroAlfa.Nome);
            Console.WriteLine("Ataque:");
            Console.WriteLine(attackGuerreiro);
            Console.WriteLine("Level guerreiro");
            Console.WriteLine(guerreiroAlfa.Level);
            Console.WriteLine();
            Console.WriteLine("Nome mago:");
            Console.WriteLine(magoAlfa.Nome);
            Console.WriteLine("Ataque:");
            Console.WriteLine(attackMago);
            Console.WriteLine("Level mago");
            Console.WriteLine(magoAlfa.Level);
            Console.WriteLine();
            Console.WriteLine("Quantidade de personagens");
            Console.WriteLine(somaCount);
        }
    }
}

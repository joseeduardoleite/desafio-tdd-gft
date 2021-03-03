using System;
using System.Collections.Generic;

namespace ExPersonagens.Domain.Entities
{
    public class Mago : Personagem
    {
        public List<string> Magia { get; set; }

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> magia) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Magia = magia;
        }

        public override void lvlUp()
        {
            if (Level < 1)
                throw new ArgumentException("Level inválido");
            Level++;
            Mana += 10;
            Inteligencia += 10;
        }

        public override void Attack(double ataque)
        {
            if (ataque < 1)
                throw new ArgumentException("Ataque inválido");
            
            Random random = new Random();
            int numero = random.Next(300);
            ataque = (Inteligencia * Level) + numero;
        }

        public string aprenderMagia(string magias)
        {
            if (string.IsNullOrEmpty(magias))
                throw new ArgumentException("Magia inválida");
            
            Magia.Add(magias);

            return magias;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ExPersonagens.Domain.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; }

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> habilidade) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Habilidade = habilidade;
        }

        public override void lvlUp()
        {
            if (Level < 1)
                throw new ArgumentException("Level inválido");
            Level++;
            Vida += 10;
            Forca += 10;
        }

        public override void Attack(double ataque)
        {
            if (ataque < 1)
                throw new ArgumentException("Ataque inválido");
            
            Random random = new Random();
            int numero = random.Next(300);
            ataque = (Forca * Level) + numero;
        }

        public string aprenderHabilidade(string habilidade)
        {
            if (string.IsNullOrEmpty(habilidade))
                throw new ArgumentException("Habilidade inválida");
            
            Habilidade.Add(habilidade);

            return habilidade;

        }
    }
}
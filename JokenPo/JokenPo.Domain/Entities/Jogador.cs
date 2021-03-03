using JokenPo.Domain.Entities.Enums;

namespace JokenPo.Domain.Entities
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int QuantidadeVitoria { get; set; }
        public Opcoes Opcao { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
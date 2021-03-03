namespace JokenPo.Domain.Entities.Services
{
    public interface IPartida
    {
        void SelecionarOpcao(Jogador jogador);
        void VencerOuPerder(Jogador jogador1, Jogador jogador2);
        void quantidadeVitorias(Jogador jogador1, Jogador jogador2);
        void quantidadePartidas(Partida partida);
        void quantidadeEmpates(Partida partida);
    }
}
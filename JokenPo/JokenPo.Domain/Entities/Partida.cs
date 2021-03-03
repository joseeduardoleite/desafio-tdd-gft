using System;
using JokenPo.Domain.Entities.Enums;
using JokenPo.Domain.Entities.Services;

namespace JokenPo.Domain.Entities
{
    public class Partida : IPartida
    {
        public int QuantidadePartidas { get; set; }
        public int QuantidadeEmpates { get; set; }

        public void SelecionarOpcao(Jogador jogador)
        {
            if (string.IsNullOrEmpty(jogador.Nome)) {
                throw new ArgumentException("Nome do jogador inválido");
            }

            if (jogador.Opcao < (Opcoes)1 || jogador.Opcao > (Opcoes)3) {
                throw new ArgumentException("Opção inválida");
            }

            Random random = new Random();
            int numeroRandon = random.Next(150);

            if (numeroRandon > 1 && numeroRandon <= 50) {
                jogador.Opcao = (Opcoes)0;
            }

            if (numeroRandon > 50 && numeroRandon <= 100) {
                jogador.Opcao = (Opcoes)1;
            }

            if (numeroRandon > 100 && numeroRandon <= 150) {
                jogador.Opcao = (Opcoes)2;
            }
        }

        public void VencerOuPerder(Jogador jogador1, Jogador jogador2)
        {

            if (string.IsNullOrEmpty(jogador1.Nome) || string.IsNullOrEmpty(jogador2.Nome)) {
                throw new ArgumentException("Nome dos jogadores inválidos");
            }

            if (jogador1.Opcao < (Opcoes)1 || jogador1.Opcao > (Opcoes)3) {
                throw new ArgumentException("Opção inválida");
            }

            if (jogador2.Opcao < (Opcoes)1 || jogador2.Opcao > (Opcoes)3) {
                throw new ArgumentException("Opção inválida");
            }

            QuantidadePartidas++;
            
            if (jogador1.Opcao.Equals(jogador2.Opcao)) {
                QuantidadeEmpates++;
                Console.WriteLine("\nOpção escolhida do jogador 1 - " + jogador1.Nome + ": " + jogador1.Opcao);
                Console.WriteLine("Opção escolhida do jogador 2 - " + jogador2.Nome + ": " + jogador2.Opcao);
                Console.WriteLine("\nResultado da partida: \n");
                Console.WriteLine("Empate");
            }

            if (jogador1.Opcao == (Opcoes)0 && jogador2.Opcao == (Opcoes)1) {
                jogador2.QuantidadeVitoria++;
                Console.WriteLine("\nOpção escolhida do jogador 1 - " + jogador1.Nome + ": " + jogador1.Opcao);
                Console.WriteLine("Opção escolhida do jogador 2 - " + jogador2.Nome + ": " + jogador2.Opcao);
                Console.WriteLine("\nResultado da partida: \n");
                Console.WriteLine("Jogador 2 - " + jogador2.Nome + ", venceu esta partida");
            }

            if (jogador1.Opcao == (Opcoes)0 && jogador2.Opcao == (Opcoes)2) {
                jogador1.QuantidadeVitoria++;
                Console.WriteLine("\nOpção escolhida do jogador 1 - " + jogador1.Nome + ": " + jogador1.Opcao);
                Console.WriteLine("Opção escolhida do jogador 2 - " + jogador2.Nome + ": " + jogador2.Opcao);
                Console.WriteLine("\nResultado da partida: \n");
                Console.WriteLine("Jogador 1 - " + jogador1.Nome + ", venceu esta partida");
            }
            
            if (jogador2.Opcao == (Opcoes)0 && jogador1.Opcao == (Opcoes)2) {
                jogador2.QuantidadeVitoria++;
                Console.WriteLine("\nOpção escolhida do jogador 1 - " + jogador1.Nome + ": " + jogador1.Opcao);
                Console.WriteLine("Opção escolhida do jogador 2 - " + jogador2.Nome + ": " + jogador2.Opcao);
                Console.WriteLine("\nResultado da partida: \n");
                Console.WriteLine("Jogador 2 - " + jogador2.Nome + ", venceu esta partida");
            }

            if (jogador1.Opcao == (Opcoes)1 && jogador2.Opcao == (Opcoes)2) {
                jogador2.QuantidadeVitoria++;
                Console.WriteLine("\nOpção escolhida do jogador 1 - " + jogador1.Nome + ": " + jogador1.Opcao);
                Console.WriteLine("Opção escolhida do jogador 2 - " + jogador2.Nome + ": " + jogador2.Opcao);
                Console.WriteLine("\nResultado da partida: \n");
                Console.WriteLine("Jogador 2 - " + jogador2.Nome + ", venceu esta partida");
            }
        }

        public void quantidadeVitorias(Jogador jogador1, Jogador jogador2)
        {
            if (string.IsNullOrEmpty(jogador1.Nome) || string.IsNullOrEmpty(jogador2.Nome)) {
                throw new ArgumentException("Nome dos jogadores inválidos");
            }

            if (jogador1.QuantidadeVitoria < 0 || jogador2.QuantidadeVitoria < 0) {
                throw new ArgumentException("Quantidade de vitórias dos jogadores inválidas");
            }

            Console.WriteLine("Quantidade de vitórias do jogador 1 - " + jogador1.Nome + ": " + jogador1.QuantidadeVitoria);
            Console.WriteLine("\nQuantidade de vitórias do jogador 2 - " + jogador2.Nome + ": " + jogador2.QuantidadeVitoria);
        }

        public void quantidadeEmpates(Partida partida)
        {
            if (partida.QuantidadeEmpates < 0) {
                throw new ArgumentException("Quantidade de empates dos jogadores inválidos");
            }
            
            Console.WriteLine("\nQuantidade de empates: " + partida.QuantidadeEmpates);
        }

        public void quantidadePartidas(Partida partida)
        {
            if (partida.QuantidadePartidas < 0) {
                throw new ArgumentException("Quantidade de partidas dos jogadores inválidas");
            }

            Console.WriteLine("Quantidade de partidas: " + partida.QuantidadePartidas);
        }
    }
}
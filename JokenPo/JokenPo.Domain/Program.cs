using System;
using JokenPo.Domain.Entities;

namespace JokenPo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Jogador jogador1 = new Jogador("Eduardo");
            Jogador jogador2 = new Jogador("Malikoski");
                        
            Partida partida = new Partida();

            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Digite a opcao desejada");
                Console.WriteLine("1 - Jogar");
                Console.WriteLine("2 - Mostrar a quantidade de vitórias dos jogadores e empates");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        partida.SelecionarOpcao(jogador1);
                        partida.SelecionarOpcao(jogador2);

                        partida.VencerOuPerder(jogador1, jogador2);
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        partida.quantidadePartidas(partida);
                        partida.quantidadeVitorias(jogador1, jogador2);
                        partida.quantidadeEmpates(partida);
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar o programa");
                        Console.WriteLine("\nPressione qualquer tecla para sair");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida\n");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                        Console.ReadKey();
                        break;
                }
            }            
        }
    }
}

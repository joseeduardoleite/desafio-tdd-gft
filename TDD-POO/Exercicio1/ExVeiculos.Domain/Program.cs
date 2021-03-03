using System;
using ExVeiculos.Domain.Entities;

namespace ExVeiculos.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            Console.WriteLine("Qual a marca do carro?");
            veiculo.Marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do carro?");
            veiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Qual a placa do carro?");     
            veiculo.Placa = Console.ReadLine();
            Console.WriteLine("Qual a cor do carro?");
            veiculo.Cor = Console.ReadLine();
            Console.WriteLine("Quantos km tem o carro?");
            veiculo.Km = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preco do carro?");
            veiculo.Preco = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(veiculo.ToString());

            int resposta = 0;
            while (resposta != 7)
            {
                 System.Console.WriteLine("Selecione a opcao para seu carro:");
                 System.Console.WriteLine("- Ligar 1\n- Acelerar 2\n- Abastecer 3\n- Frear 4\n- Pintar 5\n- Desligar 6\n- Parar o programa 7\n");
                 resposta = int.Parse(Console.ReadLine());
                    switch (resposta)
                {
                    case 1:
                        veiculo.Ligar();
                        Console.WriteLine("Voce ligou o carro");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        veiculo.Acelerar();
                        System.Console.WriteLine("Voce acelerou 20 km");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Quanto de combustivel? (max 60)");
                        int quantidadeCombustivel;
                        quantidadeCombustivel = int.Parse(Console.ReadLine());
                        veiculo.Abastecer(quantidadeCombustivel);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        veiculo.Frear();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Que cor deseja pintar?");
                        string cor = Console.ReadLine();
                        veiculo.Pintar(cor);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        veiculo.Desligar();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        System.Console.WriteLine("Obrigado por utilizar o programa :)");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        System.Console.WriteLine("Opcao invalida!");
                        break;
                }
            }
        }
    }
}

using System;

namespace ExVeiculos.Domain.Entities
{
    public class Veiculo : ArgumentException
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public double Km { get; set; }
        public bool isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public double Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo() { }
        public Veiculo(string marca, string modelo, string placa, string cor, double km, bool isLigado, int litrosCombustivel, double velocidade, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }

        public void Acelerar()
        {
            if (isLigado == false)
                throw new ArgumentException("Você não pode acelerar com o carro desligado");
            
            Velocidade += 20;
        }
        
        public void Abastecer(int combustivel)
        {
            if (combustivel > 60)
                throw new ArgumentException("Excedeu o limite da quantidade de combustível");
            
            litrosCombustivel = combustivel;
            Console.WriteLine(("Abastecido"));
        }

        public void Frear()
        {
            if (Velocidade == 0 || isLigado == false)
                throw new ArgumentException("Não foi possível frear!");
            
            Velocidade -= 20;
        }

        public void Pintar(string cor)
        {
            if (string.IsNullOrEmpty(cor))
                throw new ArgumentException("Cor inválida");
            
            Cor = cor;
            Console.WriteLine("Pintura feita com sucesso");
        }

        public void Ligar()
        {
            if (isLigado == true)
                throw new ArgumentException("O carro já está ligado!");

            isLigado = true;
        }

        public void Desligar()
        {
            if (Velocidade > 0)
                throw new ArgumentException("Não é possível desligar o carro em movimento");

            if (isLigado == false)
                throw new ArgumentException("O carro já está desligado");
            
            isLigado = false;
            Console.WriteLine("Voce desligou o carro");
        }

        public override string ToString()
        {
            return "Dados do seu carro:\n" + Marca + "\n" + Modelo + "\n" + Placa + "\n" + Cor + "\n" + Km + "\n" + Preco + "\n";
        }
    }
}
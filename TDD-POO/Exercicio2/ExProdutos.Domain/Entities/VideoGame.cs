using System;
using ExProdutos.Domain.Services;

namespace ExProdutos.Domain.Entities
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool isUsado { get; set; }

        public VideoGame() { }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            this.isUsado = isUsado;
        }

        public double calculaImposto()
        {
            if (Preco < 1) {
                throw new ArgumentException("Preço inválido para calcular imposto");
            }
            
            if (isUsado)
                Preco *= 0.25;
            else
                Preco *=  0.45;

            return Preco;
        }
    }
}
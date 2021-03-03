using System;
using ExProdutos.Domain.Services;

namespace ExProdutos.Domain.Entities
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int quantidadePaga { get; set; }

        public Livro() { }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int quantidadePaga) : base (nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            this.quantidadePaga = quantidadePaga;
        }

        public double calculaImposto()
        {
            if (string.IsNullOrEmpty(Tema))
                throw new ArgumentException("Tema inválido para calcular imposto");

            if (Preco < 1)
                throw new ArgumentException("Preço inválido para calcular imposto");
            
            if (Tema != "educativo")
                Preco *= 0.10;
            
            return Preco;
        }
    }
}
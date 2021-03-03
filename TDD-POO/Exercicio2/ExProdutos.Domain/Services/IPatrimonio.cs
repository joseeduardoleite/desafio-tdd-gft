using System.Collections.Generic;
using ExProdutos.Domain.Entities;

namespace ExProdutos.Domain.Services
{
    public interface IPatrimonio
    {
         public double calculaPatrimonio(List<Livro> livro, List<VideoGame> game);
    }
}
using System.Collections.Generic;
using ExProdutos.Domain.Entities;

namespace ExProdutos.Domain.Services
{
    public interface ILista
    {
         public void listaVideoGames(List<VideoGame> videoGames);

         public void listaLivros(List<Livro> livros);
    }
}
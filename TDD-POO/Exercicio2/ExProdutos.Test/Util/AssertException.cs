using System;
using Xunit;

namespace ExProdutos.Test.Util
{
    public static class AssertException
    {
        public static void ComMensagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem)
                Assert.True(true);
            else
                Assert.False(true, $"Esperava '{mensagem}'");
        }

    }
}
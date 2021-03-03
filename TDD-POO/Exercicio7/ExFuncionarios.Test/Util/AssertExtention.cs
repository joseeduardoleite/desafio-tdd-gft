using System;
using Xunit;

namespace ExFuncionarios.Test.Util
{
    public static class AssertExtention
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
using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWordServiseTest
{
[Fact]
public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
{
// Arrange (Preparação)
var service = new HelloWordServise();
// Act (Ação)
var resultado = service.GerarSaudacao(null);
// Assert (Verificação)
Assert.Equal("Olá, Mundo!", resultado);
}
}

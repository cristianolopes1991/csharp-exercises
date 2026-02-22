using Exercises.EstruturaSequencial;

namespace Exercises.Tests.EstruturaSequencial;

public class SomarSimplesTests
{
    // --- 1. TESTES DE SUCESSO (Caminho Feliz) ---
    [Theory]
    [InlineData(10, 30, 40)]
    [InlineData(-30, 10, -20)]
    [InlineData(0, 0, 0)]
    public void CalcularNumeros_ComValoresValidos_DeveRetornarSomaCorreta(int v1, int v2, int resultadoEsperado)
    {
        //Arrange
        var exercicio = new SomaSimples();

        // Act
        var resultadoReal = exercicio.SomarNumeros(v1, v2);

        // Assert (Garante que o resultado real é EXATAMENTE IGUAL ao esperado)
        Assert.Equal(resultadoEsperado, resultadoReal);
    }

    [Fact]
    public void CalcularNumeros_ComSomaIncorreta_NaoDeveRetornarValorEsperado()
    {
        //Arrange
        var exercicio = new SomaSimples();

        //Act
        var resultaReal = exercicio.SomarNumeros(-2, -2);

        //Assert (Garante que 2 + 2 NÃO vai retornar o valor 5)
        Assert.NotEqual(5, resultaReal);
    }
}
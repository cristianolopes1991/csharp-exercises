using Exercises.EstruturaSequencial;

namespace Exercises.Tests.EstruturaSequencial;

public class DiferencaProdutoTests
{
    [Theory]
    // Cenário 1: Vamores positivos comuns (5 * 6) - (7 * 8) = 30 - 56 = -26
    [InlineData(5,6,7,8, "DIFERENCA = -26")]

    //Cenário 2: Envolvendo números negativos ((5 * 6) - (-7 * 8) = 30 - (-56) = 86
    [InlineData(5, 6, -7, 8, "DIFERENCA = 86")]

    // Cenário 3: Zerando uma das partes (0 * 0) - (5 * 5) = 0 - 25 = -25
    [InlineData(0, 0, 5, 5, "DIFERENCA = -25")]
    public void Calcular_ComValoresInteiros_DeveRetornarDiferencaFormatada(int a, int b, int c, int d, string resultadoEsperado)
    {
        // Arrange
        var exercicio = new DiferencaProduto();

        // Act
        var resultadoReal = exercicio.Calcular(a, b, c, d);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoReal);
    }
}
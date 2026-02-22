using Exercises.EstruturaSequencial;

namespace Exercises.Tests.EstruturaSequencial;

public class CalculoValorPagoTests
{
    [Theory]
    // Cenário 1: 1 peça de R$ 5.30 e 2 peças de R$ 5.10 = R$ 15.50
    [InlineData(12, 1, 5.30, 16, 2, 5.10, "VALOR A PAGAR: R$ 15.50")]

    // Cenário 2: 2 peças de R$ 15.30 e 4 peças de R$ 5.20 = R$ 51.40
    [InlineData(13, 2, 15.30, 161, 4, 5.20, "VALOR A PAGAR: R$ 51.40")]

    // Cenário 3: 1 peça de R$ 15.10 e 1 peça de R$ 15.10 = R$ 30.20
    [InlineData(1, 1, 15.10, 2, 1, 15.10, "VALOR A PAGAR: R$ 30.20")]
    public void Calcular_ComDuasPecas_DeveRetornarValorTotalFormatado(
        int cod1, int qtd1, double valor1,
        int cod2, int qtd2, double valor2,
        string resultadoEsperado)
    {
        // Arrange
        var exercicio = new CalculoValorPago();

        // Act
        var resultadoReal = exercicio.Calcular(cod1, qtd1, valor1, cod2, qtd2, valor2);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoReal);
    }
}
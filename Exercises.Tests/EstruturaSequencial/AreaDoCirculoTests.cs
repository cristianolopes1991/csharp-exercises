using Exercises.EstruturaSequencial;

namespace Exercises.Tests.EstruturaSequencial;

public class AreaDoCirculoTests
{
    [Theory]
    [InlineData(2.000, "A=12.5664")]
    [InlineData(100.64, "A=31819.3103")]
    [InlineData(150.00, "A=70685.7750")]
    public void CalcularArea_ComRaioValido_DeveRetornarAreaFormatadaComQuatroCasas(double raio, string resultadoEsperado)
    {
        //Arrange
        var exercicio = new AreaDoCirculo();

        //Act
        var resultadoReal = exercicio.calcularArea(raio);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoReal);
    }
}
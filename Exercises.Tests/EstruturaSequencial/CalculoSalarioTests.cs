using System;
using Exercises.EstruturaSequencial;

namespace Exercises.Tests.EstruturaSequencial;

public class CalculoSalarioTests
{
    [Theory]
    [InlineData(25, 100, 5.50, "NUMBER = 25\nSALARY = U$ 550.00")]
    [InlineData(1, 200, 20.50, "NUMBER = 1\nSALARY = U$ 4100.00")]
    [InlineData(6, 145, 15.55, "NUMBER = 6\nSALARY = U$ 2254.75")]
    public void Calcular_ComDadosValidos_DeveRetornarNumeroESalarioFormatados(int numero, int horas, double valor, string resultadoEsperadoBase)
    {
        // Arrange
        var exercicio = new CalculoSalario();
        string resultadoEsperado = resultadoEsperadoBase.Replace("\n", Environment.NewLine);

        // Act
        var resultadoReal = exercicio.Calcular(numero, horas, valor);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoReal);

    }
}
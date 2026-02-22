using System.Globalization;

namespace Exercises.EstruturaSequencial;

public class CalculoValorPago
{
    public string Calcular(int codigoPeca1, int quantidadePeca1, double valorUnitarioPeca1,
    int codigoPeca2, int quantidadePeca2, double valorUnitarioPeca2)
    {
        double totalPeca1 = quantidadePeca1 * valorUnitarioPeca1;
        double totalPeca2 = quantidadePeca2 * valorUnitarioPeca2;

        double valorTotal = totalPeca1 + totalPeca2;

        string valorFormatado = valorTotal.ToString("F2", CultureInfo.InvariantCulture);

        return $"VALOR A PAGAR: R$ {valorFormatado}";
    }
}
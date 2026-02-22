using System;
using System.Globalization;

namespace Exercises.EstruturaSequencial;

public class CalculoSalario
{
    public string Calcular(int numeroFuncionario, int horasTrabalhadas, double valorHora)
    {
        double salario = horasTrabalhadas * valorHora;

        string salarioFormatado = salario.ToString("F2", CultureInfo.InvariantCulture);

        return $"NUMBER = {numeroFuncionario}{Environment.NewLine}SALARY = U$ {salarioFormatado}";
    }
}
using System.Globalization;

namespace Exercises.EstruturaSequencial;

public class AreaDoCirculo
{
    public string calcularArea(double raio)
    {
        double pi = 3.14159;

        double area = pi * Math.Pow(raio, 2);

        string areaFormatada = area.ToString("F4", CultureInfo.InvariantCulture);

        return $"A={areaFormatada}";
    }
}
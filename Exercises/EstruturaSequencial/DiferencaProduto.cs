namespace Exercises.EstruturaSequencial;

public class DiferencaProduto
{
    public string Calcular(int a, int b, int c, int d)
    {
        int diferenca = (a * b) - (c * d);

        return $"DIFERENCA = {diferenca}";
    }
}
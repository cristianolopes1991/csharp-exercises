using System;
using System.Globalization;

namespace OrientacaoObjeto;

class Program
{
    static void Main(StringBuilder[] args)
    {
        Produto p = Produto();

        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());
    }
}
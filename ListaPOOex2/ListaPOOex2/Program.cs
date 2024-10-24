using System;

class Quadrado
{
    public double Aresta { get; set; }

    public double CalcularArea()
    {
        return Aresta * Aresta;
    }
}

class Program
{
    static void Main()
    {
        Quadrado quadrado = new Quadrado();
        quadrado.Aresta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A área do quadrado é: {quadrado.CalcularArea()}");
    }
}
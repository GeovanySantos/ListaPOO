using System;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando um objeto da classe Retangulo
        Retangulo retangulo = new Retangulo();

        // Entrada de dados
        Console.Write("Digite a base do retângulo: ");
        retangulo.Base = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = Convert.ToDouble(Console.ReadLine());

        // Calculando e exibindo a área
        double area = retangulo.CalcularArea();
        Console.WriteLine($"A área do retângulo é: {area}");
    }
}

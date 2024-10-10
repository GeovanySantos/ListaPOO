class Retangulo
{
    // Propriedades para base e altura do retângulo
    public double Base { get; set; }
    public double Altura { get; set; }

    // Método para calcular a área
    public double CalcularArea()
    {
        return Base * Altura;
    }
}
using Polimorfismo;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculo = new Veiculo[2];

        veiculo[0] = new Automovel("Fusca");
        veiculo[1] = new Aeronave("Teco-Teco");

        MovimentarVeiculo(veiculo[0]);
        MovimentarVeiculo(veiculo[1]);
        Console.ReadKey();
    }
    private static void MovimentarVeiculo(Veiculo veiculo)
    {
        Console.WriteLine(veiculo.Tipo);
        veiculo.Mover();
    }
}
using System;
class Main
{
    public static void Main(string[] args)
    {
        ContadorVotos contadorVotos = new ContadorVotos(1000, 800, 150, 50);
        Console.WriteLine("Percentual dos votos válidos: " + contadorVotos.getValidVotePercentual() + " %");
        Console.WriteLine("Percentual dos votos brancos: " + contadorVotos.getBlankVotePercentual() + " %");
        Console.WriteLine("Percentual dos votos nulos: " + contadorVotos.getNullVotePercentual() + " %");

    }
}

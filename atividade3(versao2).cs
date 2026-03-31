public static class atividade3versãoDa03
{
    public static void Executar()
    {
        int numeroUm;
        int numeroDois;
        int numeroTres;
        int auxiliar;

        Console.Write("Digite o primeiro número: ");
        numeroUm = int.Parse(Console.ReadLine()!);

        Console.Write("Dois o segundo número: ");
        numeroDois = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o terceiro: ");
        numeroTres = int.Parse(Console.ReadLine()!);

        if (numeroUm > numeroDois)
        {
            auxiliar = numeroUm;
            numeroUm = numeroDois;
            numeroDois = auxiliar;
        }

        if (numeroUm > numeroTres)
        {
            auxiliar = numeroUm;
            numeroUm = numeroDois;
            numeroTres = auxiliar;
        }

        if (numeroDois > numeroTres)
        {
            auxiliar = numeroDois;
            numeroDois = numeroTres;
            numeroTres = auxiliar;
        }

        Console.WriteLine($"Ordem crescente: {numeroUm}, {numeroDois}, {numeroTres}");
    }
}


/*Ref (5 pontos)1 - Faça um programa que calcule e apresente o valor do volume de uma lata, 
sabendo que PI é um valor constante de 3.14159,
 o programa deve pedir os valores de RAIO e ALTURA,
 utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome:
*/


public static class Atividade1
{
    public static void Executar()
    {
        double pi = 3.14159;
        double raio = 10;
        double altura = 2;

        Console.WriteLine();

        Console.WriteLine("Digite o valor do raio");
        raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite o valor da altura");
        altura = double.Parse(Console.ReadLine()!);

        double total = pi * (raio * raio) * altura;
        Console.WriteLine($"0 volume da lata é: {altura}");

    }

}
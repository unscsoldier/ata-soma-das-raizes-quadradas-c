using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());

        double raiz1 = Math.Sqrt(numero1);
        double raiz2 = Math.Sqrt(numero2);

        double soma = raiz1 + raiz2;

        Console.WriteLine(soma.ToString("F1"));
    }
}
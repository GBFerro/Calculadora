internal class Program
{
    private static void Main(string[] args)
    {
        float n1, n2;

        Console.WriteLine("Escreva o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escreva o segundo número: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("A soma é: " + (n1 + n2));
        Console.WriteLine("A subtração é: " + (n1 - n2));
        Console.WriteLine("A multiplicação é: " + (n1 * n2));
        if (n2 == 0)
        {
            Console.WriteLine("Segundo número não pode se zero");
        } else { 
            Console.WriteLine("A divisão é: " + (n1 / n2).ToString("F1"));
        }
    }
}
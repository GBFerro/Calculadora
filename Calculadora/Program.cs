double num1, num2;
int opcao = 0;

void Soma(double a, double b)
{
    Console.WriteLine($"A soma dos números é: {a + b}");
    Console.ReadLine();
}

void Subtracao(double a, double b)
{
    Console.WriteLine($"A subtração dos números é: {a - b}");
    Console.ReadLine();
}

void Multiplicacao(double a, double b)
{
    Console.WriteLine($"A multiplicação dos números é: {a * b}");
    Console.ReadLine();
}

void Divisao(double a, double b)
{
    Console.WriteLine($"A divisão dos números é: {a / b}");
    Console.ReadLine();
}

int Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção:  ");
    return int.Parse(Console.ReadLine());
}

double Valores()
{
    Console.Write("Informe o valor: ");
    return double.Parse(Console.ReadLine());
}

int EscolheOperacao()
{
    switch (Menu())
    {
        default:
            Console.WriteLine("Opção inválida!!");
            Console.ReadLine();
            return 0;
        case 1:
            Soma(num1, num2);
            return 1;
        case 2:
            Subtracao(num1, num2);
            return 2;
        case 3:
            Multiplicacao(num1, num2);
            return 3;
        case 4:
            Divisao(num1, num2);
            return 4;
        case 5:
            Console.WriteLine($"Volte sempre!");
            Console.ReadLine();
            return 5;
    }
}



num1 = Valores();
num2 = Valores();

while (opcao != 5)
{
    opcao = EscolheOperacao();


}

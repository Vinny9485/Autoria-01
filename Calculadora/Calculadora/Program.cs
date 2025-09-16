using System.ComponentModel.Design;
string opcao;
do
{
    Console.Clear();
    Console.WriteLine("--------------------------");
    Console.WriteLine("       Calculadora        ");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Escolha uma das operções abaixo:");
    Console.WriteLine("(1) Adição \n(2) Subtração \n(3) Multiplicação \n(4) Divisão");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": // Adição
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Adição de dois números  ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double num2 = double.Parse(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine("Total:");
            Console.WriteLine($"{soma}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
        case "2": // Subtração
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Subtração de dois números ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite um número");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double n2 = double.Parse(Console.ReadLine());
            double subtração = n1 - n2;
            Console.WriteLine("Total:");
            Console.WriteLine($"{subtração}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
        case "3": // Multiplicação
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Mutiplicação de dois números");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite um número");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double n4 = double.Parse(Console.ReadLine());
            double multiplicacao = n3 * n4;
            Console.WriteLine("Total:");
            Console.WriteLine($"{multiplicacao}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
        case "4":// Divisão
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Divisão de dois números ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Digite um número");
            double n5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double n6 = double.Parse(Console.ReadLine());
            double divisao = n5 / n6;
            Console.WriteLine("Total:");
            Console.WriteLine($"{divisao}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("--------------------------");
            Console.WriteLine("      Opção inválida!     ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
    }
} while (opcao != "4");
Console.WriteLine("Programa finalizado.");
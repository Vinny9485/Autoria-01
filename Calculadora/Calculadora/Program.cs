using System.ComponentModel.Design; // (Este 'using' não é necessário neste código específico)

// Declaração da variável que armazenará a opção escolhida pelo usuário
string opcao;

do
{
    // Limpa a tela do console a cada repetição
    Console.Clear();

    // Exibe o menu principal
    Console.WriteLine("--------------------------");
    Console.WriteLine("       Calculadora        ");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Escolha uma das operções abaixo:");
    Console.WriteLine("(1) Adição \n(2) Subtração \n(3) Multiplicação \n(4) Divisão \n(0) Sair");

    // Lê a opção digitada pelo usuário
    opcao = Console.ReadLine();

    // Verifica qual operação o usuário escolheu
    switch (opcao)
    {
        case "1": // Adição
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Adição de dois números  ");
            Console.WriteLine("--------------------------");

            // Solicita e lê o primeiro número
            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine());

            // Solicita e lê o segundo número
            Console.WriteLine("Digite outro número");
            double num2 = double.Parse(Console.ReadLine());

            // Calcula a soma
            double soma = num1 + num2;

            // Exibe o resultado
            Console.WriteLine("Total:");
            Console.WriteLine($"{soma}");
            Console.WriteLine("--------------------------");

            // Aguarda o usuário pressionar Enter para voltar ao menu
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;

        case "2": // Subtração
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Subtração de dois números ");
            Console.WriteLine("---------------------------");

            // Solicita e lê o primeiro número
            Console.WriteLine("Digite um número");
            double n1 = double.Parse(Console.ReadLine());

            // Solicita e lê o segundo número
            Console.WriteLine("Digite outro número");
            double n2 = double.Parse(Console.ReadLine());

            // Calcula a subtração
            double subtração = n1 - n2;

            // Exibe o resultado
            Console.WriteLine("Total:");
            Console.WriteLine($"{subtração}");
            Console.WriteLine("--------------------------");

            // Aguarda o usuário pressionar Enter
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;

        case "3": // Multiplicação
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Mutiplicação de dois números");
            Console.WriteLine("---------------------------");

            // Solicita e lê o primeiro número
            Console.WriteLine("Digite um número");
            double n3 = double.Parse(Console.ReadLine());

            // Solicita e lê o segundo número
            Console.WriteLine("Digite outro número");
            double n4 = double.Parse(Console.ReadLine());

            // Realiza a multiplicação
            double multiplicacao = n3 * n4;

            // Exibe o resultado
            Console.WriteLine("Total:");
            Console.WriteLine($"{multiplicacao}");
            Console.WriteLine("--------------------------");

            // Aguarda o usuário pressionar Enter
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;

        case "4": // Divisão
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Divisão de dois números ");
            Console.WriteLine("--------------------------");

            // Solicita e lê o primeiro número
            Console.WriteLine("Digite um número");
            double n5 = double.Parse(Console.ReadLine());

            // Solicita e lê o segundo número
            Console.WriteLine("Digite outro número");
            double n6 = double.Parse(Console.ReadLine());

            // Realiza a divisão
            double divisao = n5 / n6;

            // Exibe o resultado
            Console.WriteLine("Total:");
            Console.WriteLine($"{divisao}");
            Console.WriteLine("--------------------------");

            // Aguarda o usuário pressionar Enter
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;

        case "0": // Sair do programa
            Console.WriteLine("Programa finalizado.");
            break;

        default: // Caso o usuário digite uma opção inválida
            Console.WriteLine("--------------------------");
            Console.WriteLine("      Opção inválida!     ");
            Console.WriteLine("--------------------------");

            // Aguarda Enter para voltar ao menu
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
            break;
    }
} while (opcao != "0"); // O loop continua até que o usuário digite "0" para sair
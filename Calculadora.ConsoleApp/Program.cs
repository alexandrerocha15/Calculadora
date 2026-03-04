// See https://aka.ms/new-console-template for more information
using System.Net;

// Requesito 1: Nossa calculadora deve permitir a soma de dois números
// Requesito 2: Nossa calculadora deve permitir a subtração de dois números
// Requesito 3: Nossa calculadora deve permitir a multiplicação de dois números
// Requesito 4: Nossa calculadora deve permitir a divisão de dois números

bool deveContinuar = true; // atribuição

while (deveContinuar) // Condição
{
    Console.Clear();

    Console.WriteLine("------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("------------------");

    Console.WriteLine("");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma opção válida: ");
    string operacaoSelecionada = Console.ReadLine().ToUpper();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;
        continue;
    }
    else if (operacaoSelecionada != "1" &&
             operacaoSelecionada != "2" &&
             operacaoSelecionada != "3" &&
             operacaoSelecionada != "4")
    {
        Console.WriteLine("Operação Invalida!");
        Console.WriteLine("Precione ENTER e tente novamente");
        Console.ReadLine();
        continue;
    }
    
    
    Console.Write("Digite o primeiro número: ");
    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());
    
    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + segundoNumero);

    decimal resultado = 0;

    switch (operacaoSelecionada)
    {
        case "1":
        resultado = primeiroNumero + segundoNumero;
        break;

        case "2":
        resultado = primeiroNumero - segundoNumero;
        break;

        case "3":
        resultado = primeiroNumero * segundoNumero;
        break;

        case "4":
        if (segundoNumero == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Erro! Não é possivel divisão por zero.");
                Console.ReadLine();
                continue;
            }

            resultado = primeiroNumero / segundoNumero;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadLine();
            continue;
    }

    Console.WriteLine();
    
    Console.WriteLine("A operação dos dois números resulta em: " + resultado);

    Console.ReadLine();
}
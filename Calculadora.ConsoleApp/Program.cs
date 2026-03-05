// See https://aka.ms/new-console-template for more information
using System.IO.Compression;
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
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma opção válida: ");
    string operacaoSelecionada = Console.ReadLine().ToUpper();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;
        continue;
    }
    // else if (operacaoSelecionada != "1" &&
    //          operacaoSelecionada != "2" &&
    //          operacaoSelecionada != "3" &&
    //          operacaoSelecionada != "4")
    // {
    //     Console.WriteLine("Operação Invalida!");
    //     Console.WriteLine("Precione ENTER e tente novamente");
    //     Console.ReadLine();
    //     continue;
    // }
    
    //Lógica da tabuada

    if (operacaoSelecionada == "5")
    {
        Console.Write("Digite o número que deseja gerar a tabuada: ");

        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        // para cada...
        // 1. contador/iterador
        // 2. enquanto a condição for verdadeira...
        // 3. iteração da variável contadora
        
        for (int contador = 1; contador <= 10; contador = contador +1)
        {
            int resultadoTabuada = numeroTabuada * contador;

            string operacaoTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;
            
            Console.WriteLine(operacaoTabuada);
        }

        Console.ReadLine();

        continue;

    }

    // Lógica das Operações de Cálculo

    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();
    
    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.Write("Digite um número válido!");
        Console.ReadLine();

        continue;
    }


    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    switch (operacaoSelecionada) // operador do switch
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
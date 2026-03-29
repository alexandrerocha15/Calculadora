// Requesito 1: Nossa calculadora deve permitir a soma de dois números
// Requesito 2: Nossa calculadora deve permitir a subtração de dois números
// Requesito 3: Nossa calculadora deve permitir a multiplicação de dois números
// Requesito 4: Nossa calculadora deve permitir a divisão de dois números
// Requesito 5: Nossa calculadora deve permitir a operação de dois números
// Requesito 6: Nossa calculadora deve dar a possibilidade de produzir a tabuada de um número informado
// Requesito 7: Nossa calculadora deve dar a possibilidade de visualizar o histórico de operações

string[] historicoOperacoes = new string[100]; // Array / Vetor / Arranjo
int contadorOperacoes = 0;

bool deveContinuar = true; // atribuição

while (deveContinuar) // Condição
{
    Console.Clear();

    Console.WriteLine("----------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("----------------------");

    Console.WriteLine("");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("0 - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma opção válida: ");
    string operacaoSelecionada = Console.ReadLine().ToUpper();

    if (operacaoSelecionada == "0")
    {
        deveContinuar = false;
        continue;
    }
    
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

    else if (operacaoSelecionada == "6") // Visualizar o Histórico de Operações
    {
        Console.WriteLine();
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
    string textoOperacao;

    switch (operacaoSelecionada) // operador do switch
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            break;

        case "3":
            resultado = primeiroNumero * segundoNumero;
            textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
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
                textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                break;

        default:
            Console.WriteLine("Selecione uma opção válida!");
            Console.ReadLine();
            continue;
    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao; // historicoOperacoes[3]
        contadorOperacoes = contadorOperacoes + 1;
    }
    
    Console.WriteLine("A operação dos dois números resulta em: " + resultado);
    Console.Write("\nDigite ENTER para voltar ao MENU");
    Console.ReadLine();
}
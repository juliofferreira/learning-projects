using System.Collections;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Array em C#
//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do Array {idades.Length}");

//    int acumulador = 0;
//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média de idades = {media}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i + 1}ª Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.WriteLine("Digite palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}.");
//            break;
//        }
//    }
//}

//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//void TestaMediana(Array array)
//{
//    if (array == null || array.Length == 0)
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//        return;
//    }

//    double[] numerosOrdenados = (double [])array.Clone();
//    Array.Sort(numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//double MediaDaAmostra(double[] amostra)
//{
//    double media = 0;
//    double acumulador = 0;

//    if ((amostra == null) || (amostra.Length == 0))
//    {
//        Console.WriteLine("Amostra de dados nula ou vazia.");
//        return 0;
//    }
//    else
//    {
//        for (int i = 0; i < amostra.Length; i++)
//        {
//            acumulador = acumulador + amostra[i];
//        }
//        media = acumulador / amostra.Length;
//    }

//    return media;
//}

//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(874));
//    listaDeContas.Adicionar(new ContaCorrente(874));

//    var contaDoAndre = new ContaCorrente(963);
//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibeLista();
//    //Console.WriteLine("================");
//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
//    }
//}

//TestaArrayDeContasCorrentes();

#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95){Saldo=100},
    new ContaCorrente(94){Saldo=200},
    new ContaCorrente(93){Saldo=60}
};

AtendimentoCliente();
void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("===        Atendimento          ===");
        Console.WriteLine("=== 1 - Cadastrar Conta         ===");
        Console.WriteLine("=== 2 - Listar Conta            ===");
        Console.WriteLine("=== 3 - Remover Conta           ===");
        Console.WriteLine("=== 4 - Ordenar Conta           ===");
        Console.WriteLine("=== 5 - Pesquisar Conta         ===");
        Console.WriteLine("=== 6 - Sair do Sistema         ===");
        Console.WriteLine("===================================");
        Console.WriteLine("\n\n");
        Console.WriteLine("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];

        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarConta();
                break;
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }
    }
}

void ListarConta()
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("===       LISTA DE CONTAS       ===");
    Console.WriteLine("===================================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine($"Número da Conta: {item.Conta}");
        Console.WriteLine($"Saldo da Conta: {item.Saldo}");
        Console.WriteLine($"Titular da Conta: {item.Titular.Nome}");
        Console.WriteLine($"CPF do Titular: {item.Titular.Cpf}");
        Console.WriteLine($"Profissão do Titular: {item.Titular.Profissao}");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("===      CADASTRO DE CONTAS     ===");
    Console.WriteLine("===================================");
    Console.WriteLine("\n");
    Console.WriteLine("===   Informe dados da conta    ===");

    Console.WriteLine("Número da agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia);

    Console.WriteLine("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o nome do titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.WriteLine("Informe o CPF do titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.WriteLine("Informe a profissão do titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}


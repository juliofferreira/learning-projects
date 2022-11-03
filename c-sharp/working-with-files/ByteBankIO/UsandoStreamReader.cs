using System.Text;
using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine -> FIRST LINE

            //texto = leitor.ReadToEnd(); -> ALL LINES

            //var numero = leitor.Read(); -> FIRST BYTE


            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, Ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }
        }

        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(String linha)
    {
        //375 4644 2483.13 Jonatan

        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2];
        var nomeTitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}

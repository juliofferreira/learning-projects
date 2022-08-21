using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos");

        double salario = 3000.15;

        int salarioInteiro = (int)salario;

        //long variável de 64 bits
        long number = 20000000000000;

        //short variável de 32 bits
        short number2 = 16000;

        //float menos preciso que double
        float number3 = 1.62f;

        Console.WriteLine(salario);
        Console.WriteLine(salarioInteiro);
        Console.WriteLine(number);
        Console.WriteLine(number2);
        Console.WriteLine(number3);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
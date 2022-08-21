using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;
        double investimento2 = 1000;
        //rendimento de 0.5% ao mês

        int meses = 12;
        int meses2 = 0;

        for (int i = 0; i < meses; i++)
        {
            investimento *= 1.005;
        }

        while (meses2 < 12)
        {
            investimento2 *= 1.005;
            meses2++;
        }

        Console.WriteLine(investimento);
        Console.WriteLine(investimento2);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario <= 1900 && salario >= 2800)
        {
            Console.WriteLine("Você pode deduzir R$ 142,00");
        } 
        else if (salario > 2800 && salario <= 3751)
        {
            Console.WriteLine("Você pode deduzir R$ 350,00");
        } 
        else if (salario > 3751 && salario <= 4664.00)
        {
            Console.WriteLine("Você pode deduzir R$ 636,00");
        }
    }
}

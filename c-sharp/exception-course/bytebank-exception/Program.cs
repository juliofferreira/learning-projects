namespace ByteBank
{
   class Program
   {
      static void Main(string[] args)
      {
         ContaCorrente conta = new ContaCorrente(123, 123);

         Console.WriteLine(ContaCorrente.TaxaOperacao);
         Console.ReadLine();
      }
   }
}



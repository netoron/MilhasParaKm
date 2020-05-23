using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double km1 = 1.609;
            string milhas;
            double soma;
            double soma1;
            double soma2;

            Console.WriteLine("Digite em milhas para ser convertido em Km");
            milhas = Console.ReadLine();
           
            soma1 = Convert.ToDouble(km1);
            soma2 = Convert.ToDouble(milhas);
            
            soma = soma1 * soma2;
             
            Console.WriteLine($"O valor convertido em km é {soma}");
            
            
        
            
        }
    }
}

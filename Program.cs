using System;

namespace Ler5Nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um nome:");
                nomes [i]  = Console.ReadLine();
            }
            Array.Reverse(nomes);
            foreach (string i in nomes)
            {
                Console.WriteLine(""+ i);
            }
        }  
    }
}

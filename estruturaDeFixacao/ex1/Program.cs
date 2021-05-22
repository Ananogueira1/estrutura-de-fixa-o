using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ano que você nasceu");
            int idade=int.Parse(Console.ReadLine());

            int ano=int.Parse(DateTime.Now.ToString("yyyy"));

            if (ano-idade>=16){
                Console.WriteLine("Você já pode votar.");
            }

            else{
                Console.WriteLine("Você ainda não pode votar.");
            }
        }
    }
}

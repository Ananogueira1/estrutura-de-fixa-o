using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] NomesPessoas = null;
            
            NomesPessoas = new string[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escreva o {i + 1}º nome: ");
                NomesPessoas[i] = Console.ReadLine();
            }
            
            Console.WriteLine($"Escreva o nome que você deseja buscar");
            string NomeBuscar = Console.ReadLine();

            if(NomesPessoas[1] == NomeBuscar && NomesPessoas[2] == NomeBuscar && NomesPessoas[3] == NomeBuscar && NomesPessoas[4] == NomeBuscar && NomesPessoas[5] == NomeBuscar && NomesPessoas[6] == NomeBuscar && NomesPessoas[7] == NomeBuscar && NomesPessoas[8] == NomeBuscar && NomesPessoas[9] == NomeBuscar && NomesPessoas[0] == NomeBuscar){
                Console.WriteLine($"ACHEI!!!");
            }

            else{
                Console.WriteLine($"NÃO ACHEI!!!");
            }
        }
    }
}

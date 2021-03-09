using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio12
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Informe o " + i + "º numero: ");
                soma += int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\nSoma: " + soma);
            Console.ReadKey();
        }
    }
}

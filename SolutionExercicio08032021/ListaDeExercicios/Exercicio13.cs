using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio13
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("\nInforme um numero maior ou igual a zero: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("O numero deve ser maior ou igual a zero!");
            } while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

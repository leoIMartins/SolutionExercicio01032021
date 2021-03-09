using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio7
    {
        static void Main(string[] args)
        {
            int a, b, c, maior;

            Console.Write("Informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            maior = a;

            do
            {
                Console.Write("Informe o segundo valor: ");
                b = int.Parse(Console.ReadLine());
                if (b == a)
                    Console.WriteLine("Informe um valor diferente de " + a);
            } while (b == a);

            if (b > maior)
                maior = b;

            do
            {
                Console.Write("Informe o terceiro valor: ");
                c = int.Parse(Console.ReadLine());
                if (a == c || b == c)
                    Console.WriteLine("Informe um valor diferente de " + a + " e " + b);
            } while (a == c || b == c);

            if (c > maior)
                maior = c;

            Console.Write("\nMaior: " + maior);

            Console.ReadKey();
        }
    }
}

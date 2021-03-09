using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            double a, b, c;

            do
            {
                Console.Write("\nInforme a medida do lado A: ");
                a = double.Parse(Console.ReadLine());
                if (a <= 0)
                    Console.WriteLine("A medida deve ser maior do que zero!");
            } while (a <= 0);

            do
            {
                Console.Write("\nInforme a medida do lado B: ");
                b = double.Parse(Console.ReadLine());
                if (b <= 0)
                    Console.WriteLine("A medida deve ser maior do que zero!");
            } while (b <= 0);

            do
            {
                Console.Write("\nInforme a medida do lado C: ");
                c = double.Parse(Console.ReadLine());
                if (c <= 0)
                    Console.WriteLine("A medida deve ser maior do que zero!");
            } while (c <= 0);

            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
                Console.WriteLine("\nNão é um triângulo!");
            else
                Console.WriteLine("\nÉ um triângulo!");

            Console.ReadKey();
        }
    }
}

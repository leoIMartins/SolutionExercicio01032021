using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerifTriangulo
    {
        static void Main(string[] args)
        {
            string resp;
            do
            {
                Console.Clear();
                double a, b, c;

                do
                {
                    Console.Write("\nInforme a medida do lado A: ");
                    a = double.Parse(Console.ReadLine());
                    if(a <= 0)
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
                    Console.WriteLine("Não é um triângulo!");

                else if (a == b && b == c)
                    Console.WriteLine("É um triângulo equilátero!");

                else if (a == b || a == c || b == c)
                    Console.WriteLine("É um triângulo isósceles!");

                else
                    Console.WriteLine("É um triângulo escaleno");

                Console.Write("\n\nContinuar? (s/n): ");
                resp = Console.ReadLine();

            } while (resp == "s" || resp == "S");

            Console.Write("\n\nExecução finalizada");
            Console.ReadKey();
        }
    }
}

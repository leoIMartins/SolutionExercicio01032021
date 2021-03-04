using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjExercicio01032021
{
    class Eq2Grau
    {
        static void Main(string[] args)
        {
            string resp;
            do
            {
                Console.Clear();
                double a, b, c, delta;
                

                Console.Write("Informe o valor de A: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Informe o valor de B: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Informe o valor de C: ");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("X1 = " + x1);
                    Console.WriteLine("X2 = " + x2);
                }
                else if (delta == 0)
                {
                    double x = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("X = " + x);
                    
                }
                else
                {
                    Console.Write("A equação não possui raíz real");
                }

                Console.Write("\n\nContinuar? (s/n): ");
                resp = Console.ReadLine();
            } while (resp == "s" || resp == "S");

            Console.Write("\n\nExecução finalizada");
            Console.ReadKey();
        }
    }
}

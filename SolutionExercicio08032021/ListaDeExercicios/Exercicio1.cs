using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int anos, meses, dias, totalDias;

            Console.WriteLine("A seguir, informe a quantidade de anos, meses e dias que voce tem");
            Console.Write("Anos: ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("Meses: ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("Dias: ");
            dias = int.Parse(Console.ReadLine());

            totalDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("\nVoce tem " + totalDias + " dias de vida");
            Console.ReadKey();
        }
    }
}

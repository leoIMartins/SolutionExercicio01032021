using Model.Exercicio13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio13
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora();

            impressora.ReadNumber();
            impressora.PrintNumbers();

            Console.ReadKey();
        }
    }
}

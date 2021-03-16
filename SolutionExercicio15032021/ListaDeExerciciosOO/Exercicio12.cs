using Model.Exercicio12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio12
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            Console.WriteLine("\nSoma: " + leitor.ReadNumbers());

            Console.ReadKey();
        }
    }
}

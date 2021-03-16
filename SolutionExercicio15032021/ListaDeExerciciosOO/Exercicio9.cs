using Model.Exercicio9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            Leitor leitor = new Leitor();

            leitor.ReadPrices();
            
            Console.ReadKey();
        }
    }
}

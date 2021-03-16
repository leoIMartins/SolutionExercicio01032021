using Model.Exercicio11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();

            dados.ReadTemperatures();
            dados.DisplayData();

            Console.ReadKey();
        }
    }
}

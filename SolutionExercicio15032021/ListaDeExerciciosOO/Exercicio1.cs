using Model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa()
            {
                anos = 1,
                meses = 2,
                dias = 300
            };

            Console.WriteLine("Dias de vida: " + pessoa.CalcularDiasVida(pessoa.anos, pessoa.meses, pessoa.dias));
            Console.ReadKey();
        }
    }
}

using Model.Exercicio8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.InformSideA();
            triangulo.InformSideB();
            triangulo.InformSideC();
            triangulo.ValidateTriangle();

            Console.ReadKey();
        }
    }
}

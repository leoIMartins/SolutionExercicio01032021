using Model2.Exercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            Urna urna = new Urna()
            {
                eleitores = 100,
                votosBrancos = 10,
                votosNulos = 5,
                votosValidos = 85
            };

            if (urna.ValidarVotos(urna.eleitores, urna.votosBrancos, urna.votosNulos, urna.votosValidos))
            {
                Console.WriteLine("\nPorcentagem de votos brancos: " + ((urna.votosBrancos / urna.eleitores) * 100) + "%");
                Console.WriteLine("Porcentagem de votos nulos: " + ((urna.votosNulos / urna.eleitores) * 100) + "%");
                Console.WriteLine("Porcentagem de votos validos: " + ((urna.votosValidos / urna.eleitores) * 100) + "%");
            }
            else
                Console.WriteLine("\nA soma de todos os votos deve ser igual ao número de eleitores!");

            Console.ReadKey();
        }
    }
}
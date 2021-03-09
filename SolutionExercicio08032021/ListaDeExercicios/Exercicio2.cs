using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            double eleitores, votosBrancos, votosNulos, votosValidos;

            Console.Write("Informe a quantidade de eleitores no municipio: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de votos brancos: ");
            votosBrancos= int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Informe a quantidade de votos validos: ");
                votosValidos = int.Parse(Console.ReadLine());
                if((votosBrancos + votosNulos + votosValidos) != eleitores)
                    Console.WriteLine("\nA soma de todos os votos deve ser igual ao número de eleitores!");
            } while ((votosBrancos + votosNulos + votosValidos) != eleitores);
            

            Console.WriteLine("\nPorcentagem de votos brancos: " + ((votosBrancos/eleitores) * 100) + "%");
            Console.WriteLine("Porcentagem de votos nulos: " + ((votosNulos / eleitores) * 100) + "%");
            Console.WriteLine("Porcentagem de votos validos: " + ((votosValidos / eleitores) * 100) + "%");

            Console.ReadKey();
        }
    }
}

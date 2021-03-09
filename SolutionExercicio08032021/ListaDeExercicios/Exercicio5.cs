using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            double altura, peso;

            Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Informe o seu sexo (M/F): ");
            sexo = Console.ReadLine();

            if (sexo == "M" || sexo == "m")
                peso = 72.7 * altura - 58;
            else
                peso = 62.1 * altura - 44.7;

            Console.Write("\nPeso ideal: " + peso);
            Console.ReadKey();
        }
    }
}

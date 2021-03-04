using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerifIMC
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            do
            {
                Console.Write("\nInforme o peso: ");
                peso = double.Parse(Console.ReadLine());
                if (peso <= 0)
                    Console.WriteLine("O peso deve ser maior do que zero!");
            } while (peso <= 0);

            do
            {
                Console.Write("\nInforme a altura: ");
                altura = double.Parse(Console.ReadLine());
                if (altura <= 0)
                    Console.WriteLine("A altura deve ser maior do que zero!");
            } while (altura <= 0);

            imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("\nResultado: seu IMC é " + imc + ", você está magro");
            else if(imc >= 18.5 && imc < 24.9)
                Console.WriteLine("\nResultado: seu IMC é " + imc + ", você está com o peso ideal");
            else if(imc >= 24.9 && imc < 30)
                Console.WriteLine("\nResultado: seu IMC é " + imc + ", você está com sobrepeso");
            else
                Console.WriteLine("\nResultado: seu IMC é " + imc + ", você está com obesidade");

            Console.ReadKey();
        }
    }
}

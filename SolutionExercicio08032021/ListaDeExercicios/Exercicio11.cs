using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[5];
            double menor = 0, maior = 0, soma = 0;
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Informe a temperatura do " + (i + 1) + "º dia: ");
                temperatura[i] = double.Parse(Console.ReadLine());

                if(i == 0)
                {
                    menor = temperatura[i];
                    maior = temperatura[i];
                }
                else
                {
                    if (temperatura[i] > maior)
                        maior = temperatura[i];
                    if (temperatura[i] < menor)
                        menor = temperatura[i];
                }
                soma += temperatura[i];
            }

            Console.Write("\nMenor temperatura: " + menor + "°C");
            Console.Write("\nMaior temperatura: " + maior + "°C");
            Console.Write("\nTemperatura media: " + (soma/i) + "°C");

            Console.ReadKey();
        }
    }
}

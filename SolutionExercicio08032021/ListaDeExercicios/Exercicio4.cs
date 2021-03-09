using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int carrosVendidos;
            double valorVendas, salario, comissao, salarioFinal;

            Console.Write("Informe a quantidade de carros vendidos: ");
            carrosVendidos = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor total das vendas: R$");
            valorVendas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do salario fixo: R$");
            salario = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor da comissao: R$");
            comissao = int.Parse(Console.ReadLine());

            salarioFinal = salario + comissao * carrosVendidos + valorVendas * 0.05;

            Console.Write("\nSalario final: R$" + salarioFinal);

            Console.ReadKey();
        }
    }
}

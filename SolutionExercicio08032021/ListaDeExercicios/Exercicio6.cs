using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            double salario, vendas, total;

            Console.Write("Informe o salario: R$");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor das vendas: R$");
            vendas = double.Parse(Console.ReadLine());

            if (vendas <= 1500)
                total = salario + vendas * 0.03;
            else
                total = salario + 1500 * 0.03 + (vendas - 1500) * 0.05;

            Console.Write("\nSalario total: R$" + total);
            Console.ReadKey();
        }
    }
}

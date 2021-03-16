using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio10
{
    public class Estatisticas
    {
        #region Propriedades
        public double maior { get; set; }
        public double somaSalario { get; set; }
        public double salariosRuins { get; set; }
        public double somaFilhos { get; set; }
        #endregion
        #region Métodos
        public void ReadData()
        {
            double salario;
            int i, filhos;

            maior = 0;
            somaSalario = 0;
            salariosRuins = 0;
            somaFilhos = 0;

            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("\nHabitante " + i);
                Console.Write("Informe o salario: R$");
                salario = double.Parse(Console.ReadLine());

                Console.Write("Informe o numero de filhos: ");
                filhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += filhos;

                if (salario < 150)
                    salariosRuins += 1;

                if (i == 1)
                    maior = salario;
                else
                {
                    if (salario > maior)
                        maior = salario;
                }
            }
        }

        public void DisplayStatistics()
        {
            Console.Write("\nMedia salarial da populacao: R$" + (somaSalario / 4));
            Console.Write("\nMedia do numero de filhos: " + (somaFilhos / 4));
            Console.Write("\nMaior salario dos habitantes: R$" + maior);
            Console.Write("\nPercentual de pessoas com salario menor que R$150,00: " + ((salariosRuins / 4) * 100) + "%");
        }
        #endregion
    }
}

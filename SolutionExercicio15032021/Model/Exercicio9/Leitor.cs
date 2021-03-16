using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio9
{
    public class Leitor
    {
        #region Métodos
        public void ReadPrices()
        {
            double preco, maior = 0, soma = 0;
            int i;

            for (i = 1; i <= 15; i++)
            {
                Console.Write("\nLendo o código do " + i + "º produto...\n...\n");
                Console.Write("Informe o preco do " + i + "º produto: R$");
                preco = double.Parse(Console.ReadLine());
                soma += preco;
                if (i == 1)
                    maior = preco;
                else
                {
                    if (preco > maior)
                        maior = preco;
                }
            }

            Console.Write("\nMaior preco lido: R$" + maior);
            Console.Write("\nMedia aritmetica dos precos dos produtos: R$" + (soma / (i - 1)));
        }
        #endregion
    }
}

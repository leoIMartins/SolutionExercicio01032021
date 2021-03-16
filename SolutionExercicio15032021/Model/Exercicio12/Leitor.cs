using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio12
{
    public class Leitor
    {
        #region Propriedades
        public int soma { get; set; }
        #endregion

        #region Métodos
        public int ReadNumbers()
        {
            soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Informe o " + i + "º numero: ");
                this.soma += int.Parse(Console.ReadLine());
            }
            return this.soma;
        }
        #endregion
    }
}

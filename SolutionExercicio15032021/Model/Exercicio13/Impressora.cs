using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio13
{
    public class Impressora
    {
        #region Métodos
        public int n { get; set; }
        #endregion
        #region Métodos
        public int ReadNumber()
        {
            do
            {
                Console.Write("\nInforme um numero maior ou igual a zero: ");
                this.n = int.Parse(Console.ReadLine());
                if (this.n <= 0)
                    Console.WriteLine("O numero deve ser maior ou igual a zero!");
            } while (this.n <= 0);
            return this.n;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= this.n; i++)
                Console.WriteLine(i);
            
        }
        #endregion
    }
}

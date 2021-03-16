using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio7
{
    public class Dado
    {
        #region Propriedades
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        #endregion

        #region Métodos
        public double FindBigger()
        {
            int maior;

            Console.Write("Informe o primeiro valor: ");
            this.a = int.Parse(Console.ReadLine());

            maior = this.a;

            do
            {
                Console.Write("Informe o segundo valor: ");
                b = int.Parse(Console.ReadLine());
                if (b == this.a)
                    Console.WriteLine("Informe um valor diferente de " + this.a);
            } while (b == this.a);

            if (b > maior)
                maior = b;

            do
            {
                Console.Write("Informe o terceiro valor: ");
                this.c = int.Parse(Console.ReadLine());
                if (this.a == this.c || b == this.c)
                    Console.WriteLine("Informe um valor diferente de " + this.a + " e " + b);
            } while (this.a == this.c || b == this.c);

            if (this.c > maior)
                maior = this.c;

            return maior;
        }
        #endregion
    }
}


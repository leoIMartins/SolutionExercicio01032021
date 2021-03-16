using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio8
{
    public class Triangulo
    {
        #region Propriedades
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        #endregion

        #region Métodos
        public bool ZeroOrLess(int value)
        {
            if (value <= 0)
                Console.WriteLine("A medida deve ser maior do que zero!");
            return value <= 0;
        }

        public void InformSideA()
        {
            do
            {
                Console.Write("\nInforme a medida do lado A: ");
                this.a = int.Parse(Console.ReadLine());
            } while (ZeroOrLess(this.a));
        }

        public void InformSideB()
        {
            do
            {
                Console.Write("\nInforme a medida do lado B: ");
                this.b = int.Parse(Console.ReadLine());
            } while (ZeroOrLess(this.b));
        }

        public void InformSideC()
        {
            do
            {
                Console.Write("\nInforme a medida do lado C: ");
                this.c = int.Parse(Console.ReadLine());
            } while (ZeroOrLess(this.c));
        }

        public void ValidateTriangle()
        {
            if (this.a >= (this.b + this.c) || this.b >= (this.a + this.c) || this.c >= (this.a + this.b))
                Console.WriteLine("\nNão é um triângulo!");
            else
                Console.WriteLine("\nÉ um triângulo!");
        }
        #endregion
    }
}

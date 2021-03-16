using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio11
{
    public class Dados
    {
        #region Propriedades
        public double menor { get; set; }
        public double maior{ get; set; }
        public double soma { get; set; }
        #endregion
        
        #region Métodos
        public void ReadTemperatures()
        {
            double[] temperatura = new double[5];
            int i;

            this.menor = 0;
            this.maior = 0;
            this.soma = 0;
            
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Informe a temperatura do " + (i + 1) + "º dia: ");
                temperatura[i] = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    this.menor = temperatura[i];
                    this.maior = temperatura[i];
                }
                else
                {
                    if (temperatura[i] > this.maior)
                        this.maior = temperatura[i];
                    if (temperatura[i] < this.menor)
                        this.menor = temperatura[i];
                }
                this.soma += temperatura[i];
            }
        }

        public void DisplayData()
        {
            Console.Write("\nMenor temperatura: " + this.menor + "°C");
            Console.Write("\nMaior temperatura: " + this.maior + "°C");
            Console.Write("\nTemperatura media: " + (this.soma / 5) + "°C");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio6
{
    public class Vendedor
    {
        #region Propriedades
        public double salario { get; set; }
        public double vendas { get; set; }
        #endregion

        #region Métodos
        public double CalcularSalarioTotal()
        {
            double total;
            if (vendas <= 1500)
                total = salario + vendas * 0.03;
            else
                total = salario + 1500 * 0.03 + (vendas - 1500) * 0.05;

            return total;
        }
        #endregion
    }
}

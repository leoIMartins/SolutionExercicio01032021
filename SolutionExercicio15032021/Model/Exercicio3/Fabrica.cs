using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio3
{
    public class Fabrica
    {
        #region Propriedades
        public double custoFabrica { get; set; }
        #endregion

        #region Métodos
        public double CalcularCustoTotal()
        {
            return custoFabrica * 1.73;
        }
        #endregion
    }
}

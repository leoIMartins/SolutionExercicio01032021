using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        #region Propriedades
        public int anos { get; set; }
        public int meses { get; set; }
        public int dias { get; set; }
        #endregion

        #region Métodos

        public int CalcularDiasVida()
        {
            return (anos * 365) + (meses * 30) + dias; ;
        }
        #endregion
    }
}


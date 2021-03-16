using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio5
{
    public class Pessoa
    {
        #region Propriedades
        public string nome { get; set; }
        public double altura { get; set; }
        public string sexo { get; set; }
        #endregion

        #region Métodos
        public double CalcularPesoIdeal()
        {
            double peso;
            if (sexo == "M" || sexo == "m")
                peso = 72.7 * altura - 58;
            else
                peso = 62.1 * altura - 44.7;
            
            return peso;
        }
        #endregion
    }
}

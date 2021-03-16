using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio4
{
    public class Funcionario
    {
        #region Propriedades
        public int carrosVendidos { get; set; }
        public double valorVendas { get; set; }
        public double salario { get; set; }
        public double comissao { get; set; }
        #endregion

        #region Métodos
        public double CalcularSalarioFinal()
        {
            return salario + comissao * carrosVendidos + valorVendas * 0.05;
        }
        #endregion
    }
}

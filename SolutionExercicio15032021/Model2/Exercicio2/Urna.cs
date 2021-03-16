using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2.Exercicio2
{
    public class Urna
    {
        #region Propriedades
        public int eleitores { get; set; }
        public int votosBrancos { get; set; }
        public int votosNulos { get; set; }
        public int votosValidos { get; set; }
        #endregion

        #region Métodos

        public bool ValidarVotos(double eleitores, double votosBrancos, double votosNulos, double votosValidos)
        {
            return (votosBrancos + votosNulos + votosValidos) == eleitores;
                //Console.WriteLine("\nA soma de todos os votos deve ser igual ao número de eleitores!");
        }
        #endregion
    }
}

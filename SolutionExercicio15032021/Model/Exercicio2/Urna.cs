using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exercicio2
{
    public class Urna
    {
        #region Propriedades
        public double eleitores { get; set; }
        public double votosBrancos { get; set; }
        public double votosNulos { get; set; }
        public double votosValidos { get; set; }
        #endregion

        #region Métodos

        public bool ValidarVotos()
        {
            return (votosBrancos + votosNulos + votosValidos) == eleitores;
        }

        public void CalcularPercentuais()
        {
            Console.WriteLine("\nPorcentagem de votos brancos: " + ((votosBrancos / eleitores) * 100) + "%");
            Console.WriteLine("Porcentagem de votos nulos: " + ((votosNulos / eleitores) * 100) + "%");
            Console.WriteLine("Porcentagem de votos validos: " + ((votosValidos / eleitores) * 100) + "%");
        }
        #endregion
    }
}

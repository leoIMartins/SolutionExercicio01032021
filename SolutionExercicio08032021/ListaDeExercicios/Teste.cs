using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Teste
    {
        static void Main(string[] args)
        {
            string dataInicio = "01/01/2001";
            string dataFim = "01/01/2002";

            DateTime dataInicioDate = Convert.ToDateTime(dataInicio);
            DateTime dataFimDate = Convert.ToDateTime(dataFim);

            int dias = (int)dataFimDate.Subtract(dataInicioDate).TotalDays;

            Console.WriteLine(dataInicio + " - " + dataFim);
            Console.WriteLine(dataInicioDate + " - " + dataInicio.GetType());
            Console.WriteLine("Diferença de dias: " + dias);

            Console.ReadKey();
        }
    }


}

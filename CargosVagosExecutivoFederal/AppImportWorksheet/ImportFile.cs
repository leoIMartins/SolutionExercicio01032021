using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppImportWorksheet
{
    class ImportFile
    {
        static void Main(string[] args)
        {
            ImportDataFromExcel(@"C:\TopicosAvancadosEmSistemasDeInformacao\CargosVagosExecutivoFederal\LotOrgao_DistOcupVagas_202105.xls");
        }

        public static void ImportDataFromExcel(string excelFilePath)
        {
            string ssqltable = "TB_VAGAS_ORGAO";
            string myexceldataquery = "select NOME_MES,	ORGAO, NOME_ORGAO, SIGLA_ORGAO, APROVADA, DISTRIBUIDA, OCUPADA, VAGAS from [Planilha1$]";
            try
            {
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + excelFilePath +
                ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                string ssqlconnectionstring = @"Data Source=PC-LEONARDO;Initial Catalog=dbcargosvagos;Integrated Security=True";
                
                string sclearsql = "delete from " + ssqltable;

                SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
                SqlCommand sqlcmd = new SqlCommand(sclearsql, sqlconn);
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);
                bulkcopy.DestinationTableName = ssqltable;
                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }
                dr.Close();
                oledbconn.Close();
                Console.WriteLine("Dados importados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}

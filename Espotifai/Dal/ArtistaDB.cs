using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ArtistaDB : IArtistaDB
    {

        public List<Artista> GetAll()
        {
            string sql = Artista.GETALL;
            List<Artista> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Artista> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Artista>();

            while (returnData.Read())
            {
                var item = new Artista()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["nome"].ToString(),
                    Integrantes = returnData["integrantes"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Artista artista)
        {
            bool status = false;
            string sql = string.Format(Artista.INSERT, artista.Nome, artista.Integrantes);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Artista SelectById(int id)
        {
            string sql = string.Format(Artista.GETBYID, id);
            Artista artista;

            using (var connection = new DB())
            {
                artista = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return artista;
        }

        public bool Update(Artista artista, int id)
        {
            bool status = false;
            string sql = string.Format(Artista.UPDATE, artista.Nome, artista.Integrantes, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Artista.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}

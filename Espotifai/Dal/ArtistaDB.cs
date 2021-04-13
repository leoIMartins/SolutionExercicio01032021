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
                    Integrantes = returnData["integrantes"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Artista ferramenta)
        {
            bool status = false;
            string sql = string.Format(Artista.INSERT, ferramenta.Integrantes);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Artista SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Artista ferramenta)
        {
            bool status = false;
            string sql = string.Format(Artista.UPDATE, ferramenta.Integrantes, ferramenta.Id);

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

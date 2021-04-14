using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MusicaDB : IMusicaDB
    {

        public List<Musica> GetAll()
        {
            string sql = Musica.GETALL;
            List<Musica> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Musica> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Musica>();

            while (returnData.Read())
            {
                var item = new Musica()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["nome"].ToString(),
                    Duracao = returnData["duracao"].ToString(),
                    Compositor = returnData["compositor"].ToString(),
                    Genero = returnData["genero"].ToString(),
                    Album = returnData["album"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Musica musica)
        {
            bool status = false;
            string sql = string.Format(Musica.INSERT, musica.Nome, musica.Duracao, musica.Compositor, musica.Genero, musica.Album);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Musica SelectById(int id)
        {
            string sql = string.Format(Musica.GETBYID, id);
            Musica musica;

            using (var connection = new DB())
            {
                musica = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return musica;
        }

        public bool Update(Musica musica, int id)
        {
            bool status = false;
            string sql = string.Format(Musica.UPDATE, musica.Nome, musica.Duracao, musica.Compositor, musica.Genero, musica.Album, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Musica.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
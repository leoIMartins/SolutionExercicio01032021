using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AlbumDB : IAlbumDB
    {

        public List<Album> GetAll()
        {
            string sql = Album.GETALL;
            List<Album> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Album> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Album>();

            while (returnData.Read())
            {
                var item = new Album()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Nome = returnData["nome"].ToString(),
                    Lancamento = returnData["lancamento"].ToString(),
                    Gravadora = returnData["gravadora"].ToString(),
                    Artista = returnData["artista"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Album album)
        {
            bool status = false;
            string sql = string.Format(Album.INSERT, album.Nome, album.Lancamento, album.Gravadora, album.Artista);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Album SelectById(int id)
        {
            string sql = string.Format(Album.GETBYID, id);
            Album album;

            using (var connection = new DB())
            {
                album = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return album;
        }

        public bool Update(Album album, int id)
        {
            bool status = false;
            string sql = string.Format(Album.UPDATE, album.Nome, album.Lancamento, album.Gravadora, album.Artista, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Album.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
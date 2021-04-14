using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IAlbumDB
    {
        bool Insert(Album album);
        bool Update(Album album, int id);
        bool Delete(int id);
        Album SelectById(int id);
        List<Album> GetAll();
    }
}

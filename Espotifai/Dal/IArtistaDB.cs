using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IArtistaDB
    {
        bool Insert(Artista artista);
        bool Update(Artista artista, int id);
        bool Delete(int id);
        Artista SelectById(int id);
        List<Artista> GetAll();
    }
}

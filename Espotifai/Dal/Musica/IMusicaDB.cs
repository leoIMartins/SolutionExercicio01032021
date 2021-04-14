using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IMusicaDB
    {
        bool Insert(Musica musica);
        bool Update(Musica musica, int id);
        bool Delete(int id);
        Musica SelectById(int id);
        List<Musica> GetAll();
    }
}

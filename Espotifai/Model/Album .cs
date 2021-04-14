using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Album
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Lancamento{ get; set; }
        public string Gravadora { get; set; }
        public string Artista { get; set; }

        public const string INSERT = "INSERT INTO TB_ALBUM (nome, lancamento, gravadora, artista) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, nome, lancamento, gravadora, artista FROM TB_ALBUM";
        public const string UPDATE = "UPDATE TB_ALBUM SET nome = '{0}', lancamento = '{1}', gravadora = '{2}', artista = '{3}' WHERE id = {4}";
        public const string DELETE = "DELETE FROM TB_ALBUM WHERE id = {0}";
        public const string GETBYID = "SELECT id, nome, lancamento, gravadora, artista FROM TB_ALBUM WHERE id = {0}";

        public override string ToString()
        {
            return "ID: " + this.Id + "\nÁlbum: " + this.Nome + "\nLançamento: " + this.Lancamento 
                + "\nGravadora: " + this.Gravadora + "\nArtista: " + this.Artista + "\n\n";
        }

        #endregion

    }
}

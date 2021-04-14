using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Musica
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Duracao{ get; set; }
        public string Compositor { get; set; }
        public string Genero { get; set; }
        public string Album { get; set; }

        public const string INSERT = "INSERT INTO TB_MUSICA (nome, duracao, compositor, genero, album) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public const string GETALL = "SELECT id, nome, duracao, compositor, genero, album FROM TB_MUSICA";
        public const string UPDATE = "UPDATE TB_MUSICA SET nome = '{0}', duracao = '{1}', compositor = '{2}', genero = '{3}', album = '{4}' WHERE id = {5}";
        public const string DELETE = "DELETE FROM TB_MUSICA WHERE id = {0}";
        public const string GETBYID = "SELECT id, nome, duracao, compositor, genero, album FROM TB_MUSICA WHERE id = {0}";

        public override string ToString()
        {
            return "ID: " + this.Id + "\nNome: " + this.Nome + "\nDuração: " + this.Duracao 
                + "\nCompositor: " + this.Compositor + "\nGenero: " + this.Genero + "\nÁlbum: " + this.Album + "\n\n";
        }

        #endregion

    }
}

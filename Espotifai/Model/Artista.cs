using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Artista
    {
        #region Propriedades
        public int Id { get; set; }
        public string Integrantes { get; set; }
        
        public const string INSERT = "INSERT INTO TB_ARTISTA (integrantes) VALUES ('{0}')";
        public const string GETALL = "SELECT id, integrantes FROM TB_ARTISTA";
        public const string UPDATE = "UPDATE TB_ARTISTA SET integrantes = '{0}' WHERE id = {1}";
        public const string DELETE = "DELETE FROM TB_ARTISTA WHERE id = {0}";
        public const string GETBYID = "SELECT id, integrantes FROM TB_ARTISTA WHERE id = {0}";

        public override string ToString()
        {
            return "ID: " + this.Id + "\nIntegrantes: " + this.Integrantes + "\n\n";
        }

        #endregion

    }
}

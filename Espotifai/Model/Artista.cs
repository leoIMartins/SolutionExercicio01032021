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
        public string Nome { get; set; }
        public string Integrantes { get; set; }
        
        public const string INSERT = "INSERT INTO TB_ARTISTA (nome, integrantes) VALUES ('{0}', '{1}')";
        public const string GETALL = "SELECT id, nome, integrantes FROM TB_ARTISTA";
        public const string UPDATE = "UPDATE TB_ARTISTA SET nome = '{0}', integrantes = '{1}' WHERE id = {2}";
        public const string DELETE = "DELETE FROM TB_ARTISTA WHERE id = {0}";
        public const string GETBYID = "SELECT id, nome, integrantes FROM TB_ARTISTA WHERE id = {0}";

        public override string ToString()
        {
            return "ID: " + this.Id + "\nNome da banda/artista: " + this.Nome + "\nIntegrantes: " + this.Integrantes + "\n\n";
        }

        #endregion

    }
}

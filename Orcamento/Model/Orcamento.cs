using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orcamento
    {
        #region Propriedades
        public int Id { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }
        public int QtdDias { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public string Modulo { get; set; }

        public const string INSERT = "INSERT INTO TB_SQUAD (dtinicio, dtfim, qtddias, descricao, titulo, modulo) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')";
        public const string GETALL = "SELECT id, dtinicio, dtfim, qtddias, descricao, titulo, modulo FROM TB_SQUAD";
        public const string UPDATE = "UPDATE TB_SQUAD SET dtinicio = '{0}', dtfim = '{1}', qtddias = {2}, descricao = '{3}', titulo = '{4}', modulo = '{5}' WHERE id = {6}";
        public const string DELETE = "DELETE FROM TB_SQUAD WHERE id = {0}";
        public const string GETBYID = "SELECT id, dtinicio, dtfim, qtddias, descricao, titulo, modulo FROM TB_SQUAD WHERE id = {0}";

        #endregion
    }
}

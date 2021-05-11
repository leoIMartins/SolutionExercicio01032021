using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orcamento
{
    public partial class Orcamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Model.Orcamento orcamento = getData();
            var db = new OrcamentoDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(orcamento))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(orcamento, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        private Model.Orcamento getData()
        {
            return new Model.Orcamento()
            {
                DtInicio = TxtDtInicio.Text,
                DtFim = TxtDtFim.Text,
                QtdDias = diferencaDeDias(TxtDtInicio.Text, TxtDtFim.Text),
                Descricao = TxtDescricao.Text,
                Titulo = TxtTitulo.Text,
                Modulo = DdlModulo.Text,
            };
        }

        private void LoadGrid()
        {
            GVOrcamento.DataSource = new OrcamentoDB().GetAll();
            GVOrcamento.DataBind();
        }

        protected void GVOrcamento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVOrcamento.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new OrcamentoDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Model.Orcamento orcamento = db.SelectById(id);

                TxtDtInicio.Text = orcamento.DtInicio;
                TxtDtFim.Text = orcamento.DtFim.ToString();
                TxtDescricao.Text = orcamento.Descricao.ToString();
                TxtTitulo.Text = orcamento.Titulo.ToString();
                DdlModulo.Text = orcamento.Modulo.ToString();
                IdH.Value = orcamento.Id.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            IdH.Value = "0";
            TxtDtInicio.Text = "";
            TxtDtFim.Text = "";
            TxtDescricao.Text = "";
            TxtTitulo.Text = "";
            TxtDtInicio.Focus();
        }

        protected int diferencaDeDias(string dataInicio, string dataFim)
        {
            DateTime dataInicioDate = Convert.ToDateTime(dataInicio);
            DateTime dataFimDate = Convert.ToDateTime(dataFim);
            return (int)dataFimDate.Subtract(dataInicioDate).TotalDays;
        }
    }
}
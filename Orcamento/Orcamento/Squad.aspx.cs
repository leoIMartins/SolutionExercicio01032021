using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orcamento
{
    public partial class Squad : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Model.Squad squad = getData();
            var db = new SquadDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(squad))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(squad, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        private Model.Squad getData()
        {
            return new Model.Squad()
            {
                Nome = TxtNome.Text,
                QtdPessoas = int.Parse(TxtQtdPessoas.Text),
            };
        }

        private void LoadGrid()
        {
            GVSquad.DataSource = new SquadDB().GetAll();
            GVSquad.DataBind();
        }

        protected void GVSquad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVSquad.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new SquadDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Model.Squad squad = db.SelectById(id);

                TxtNome.Text = squad.Nome;
                TxtQtdPessoas.Text = squad.QtdPessoas.ToString();
                IdH.Value = squad.Id.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtQtdPessoas.Text = "";
            IdH.Value = "0";
            TxtNome.Focus();
        }
    }
}
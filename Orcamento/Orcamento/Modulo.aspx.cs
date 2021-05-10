using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orcamento
{
    public partial class Modulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Model.Modulo modulo = getData();
            var db = new ModuloDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(modulo))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(modulo, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        private Model.Modulo getData()
        {
            return new Model.Modulo()
            {
                Ambiente = DdlAmbiente.Text,
                Squad = DdlSquad.Text,
            };
        }

        private void LoadGrid()
        {
            GVModulo.DataSource = new ModuloDB().GetAll();
            GVModulo.DataBind();
        }

        protected void GVModulo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVModulo.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new ModuloDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Model.Modulo modulo = db.SelectById(id);

                DdlAmbiente.Text = modulo.Ambiente;
                DdlSquad.Text = modulo.Squad.ToString();
                IdH.Value = modulo.Id.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            IdH.Value = "0";
            DdlAmbiente.Focus();
        }

        /*protected void BtnAlbum_Click(object sender, EventArgs e)
        {
            if (GVModulo.Rows.Count == 0)
            {
                LblAlerta.Enabled = true;
                LblAlerta.Visible = true;
            }
            else
                Response.Redirect("WebForm2.aspx");
        }*/
    }
}
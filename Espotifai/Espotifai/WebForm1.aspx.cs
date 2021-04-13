using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Espotifai
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void GVArtista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Artista artista = getData();
            var db = new ArtistaDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(artista))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(artista, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        private Artista getData()
        {
            return new Artista()
            {
                Nome = TxtNome.Text,
                Integrantes = TxtIntegrantes.Text,
            };
        }

        private void LoadGrid()
        {
            GVArtista.DataSource = new ArtistaDB().GetAll();
            GVArtista.DataBind();
        }

        protected void GVArtista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVArtista.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new ArtistaDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Artista artista = db.SelectById(id);

                TxtNome.Text = artista.Nome;
                TxtIntegrantes.Text = artista.Integrantes;
                IdH.Value = artista.Id.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtIntegrantes.Text = "";
            IdH.Value = "0";
            TxtNome.Focus();
        }

        protected void BtnAlbum_Click(object sender, EventArgs e)
        {
            if(GVArtista.Rows.Count == 0)
            {
                LblAlerta.Enabled = true;
                LblAlerta.Visible = true;
            }
        }
    }
}
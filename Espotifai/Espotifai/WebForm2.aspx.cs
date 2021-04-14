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
    public partial class WebForm2 : System.Web.UI.Page
    {
        private void LoadGrid()
        {
            GVAlbum.DataSource = new AlbumDB().GetAll();
            GVAlbum.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Album album = getData();
            var db = new AlbumDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(album))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(album, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            TxtNomeAlbum.Text = "";
            TxtLancamento.Text = "";
            TxtGravadora.Text = "";
            IdH.Value = "0";
            TxtNomeAlbum.Focus();
        }

        protected void BtnMusica_Click(object sender, EventArgs e)
        {
            if (GVAlbum.Rows.Count == 0)
            {
                LblAlerta.Enabled = true;
                LblAlerta.Visible = true;
            }
            //else
            //    Response.Redirect("WebForm2.aspx");
        }

        protected void GVAlbum_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVAlbum.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new AlbumDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Album album = db.SelectById(id);

                TxtNomeAlbum.Text = album.Nome;
                TxtLancamento.Text = album.Lancamento;
                TxtGravadora.Text = album.Gravadora;
                DdlArtista.Text = album.Artista;
                IdH.Value = album.Id.ToString();
            }
        }

        private Album getData()
        {
            return new Album()
            {
                Nome = TxtNomeAlbum.Text,
                Lancamento = TxtLancamento.Text,
                Gravadora = TxtGravadora.Text,
                Artista = DdlArtista.Text,
            };
        }
    }
}
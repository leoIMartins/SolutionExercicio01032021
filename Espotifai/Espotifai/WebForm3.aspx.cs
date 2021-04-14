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
    public partial class WebForm3 : System.Web.UI.Page
    {
        private void LoadGrid()
        {
            GVMusica.DataSource = new MusicaDB().GetAll();
            GVMusica.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Musica musica = getData();
            var db = new MusicaDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(musica))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(musica, int.Parse(IdH.Value)))
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
            TxtNomeMusica.Text = "";
            TxtDuracao.Text = "";
            TxtCompositor.Text = "";
            TxtGenero.Text = "";
            IdH.Value = "0";
            TxtNomeMusica.Focus();
        }

        protected void GVMusica_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVMusica.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new MusicaDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Musica musica = db.SelectById(id);

                TxtNomeMusica.Text = musica.Nome;
                TxtDuracao.Text = musica.Duracao;
                TxtCompositor.Text = musica.Compositor;
                TxtGenero.Text = musica.Genero;
                DdlAlbum.Text = musica.Album;
                IdH.Value = musica.Id.ToString();
            }
        }

        private Musica getData()
        {
            return new Musica()
            {
                Nome = TxtNomeMusica.Text,
                Duracao = TxtDuracao.Text,
                Compositor = TxtCompositor.Text,
                Genero = TxtGenero.Text,
                Album = DdlAlbum.Text,
            };
        }
    }
}
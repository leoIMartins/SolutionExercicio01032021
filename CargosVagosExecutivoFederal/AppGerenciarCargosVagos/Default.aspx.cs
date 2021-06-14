using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppGerenciarCargosVagos
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            dbcargosvagosEntities context = new dbcargosvagosEntities();
            List<TB_VAGAS_ORGAO> lstVagas = context.TB_VAGAS_ORGAO.ToList<TB_VAGAS_ORGAO>();

            GVVagas.DataSource = lstVagas;
            GVVagas.DataBind();
        }

        protected void GVVagas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int orgao = Convert.ToInt32(e.CommandArgument.ToString());
            dbcargosvagosEntities contextVagas = new dbcargosvagosEntities();
            TB_VAGAS_ORGAO vaga = new TB_VAGAS_ORGAO();

            vaga = contextVagas.TB_VAGAS_ORGAO.First(c => c.ORGAO == orgao);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Vagas.aspx?orgao=" + orgao);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextVagas.TB_VAGAS_ORGAO.Remove(vaga);
                contextVagas.SaveChanges();
                string msg = "Vaga excluída com sucesso!";
                string titulo = "Informação";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }
    }
}
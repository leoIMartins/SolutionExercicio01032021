using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VendaCamisetas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            CamisetasDBEntities context = new CamisetasDBEntities();
            List<TB_CAMISAS> lstCamisetas = context.TB_CAMISAS.ToList<TB_CAMISAS>();

            GVCamisetas.DataSource = lstCamisetas;
            GVCamisetas.DataBind();
        }

        protected void GVCamisetas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            CamisetasDBEntities contextCamisetas = new CamisetasDBEntities();
            TB_CAMISAS camisas = new TB_CAMISAS();

            camisas = contextCamisetas.TB_CAMISAS.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Camisetas.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextCamisetas.TB_CAMISAS.Remove(camisas);
                contextCamisetas.SaveChanges();
                string msg = "Camiseta excluída com sucesso !";
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
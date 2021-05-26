using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VendaCamisetas
{
    public partial class Camisetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string descricaoCamisetas = txtDescricao.Text;
            float preco = (float)Convert.ToDouble(txtPreco.Text);
            string cor = txtCor.Text;
            string tamanho = txtTamanho.Text;
            TB_CAMISAS camisetas = new TB_CAMISAS() { descricao = descricaoCamisetas, preco = preco, cor = cor, tamanho = tamanho };
            CamisetasDBEntities contextCamisetas = new CamisetasDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextCamisetas.TB_CAMISAS.Add(camisetas);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_CAMISAS camisas = contextCamisetas.TB_CAMISAS.First(c => c.id == id);
                camisas.descricao = camisas.descricao;
                camisas.preco = camisas.preco;
                camisas.cor = camisas.cor;
                camisas.tamanho = camisas.tamanho;
                lblmsg.Text = "Registro Alterado";
            }
            contextCamisetas.SaveChanges();
        }

        private void Clear()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtCor.Text = "";
            txtTamanho.Text = "";
            txtDescricao.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_CAMISAS camisetas = new TB_CAMISAS();


            if (!String.IsNullOrEmpty(valor))
            {
                CamisetasDBEntities contextCamisetas = new CamisetasDBEntities();
                idItem = Convert.ToInt32(valor);
                camisetas = contextCamisetas.TB_CAMISAS.First(c => c.id == idItem);

                txtDescricao.Text = camisetas.descricao;
                txtPreco.Text = camisetas.preco.ToString();
                txtCor.Text = camisetas.cor;
                txtTamanho.Text = camisetas.tamanho;
            }
        }
    }
}
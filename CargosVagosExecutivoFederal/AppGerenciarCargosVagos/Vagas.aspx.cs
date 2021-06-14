using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppGerenciarCargosVagos
{
    public partial class Vagas : System.Web.UI.Page
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
            string nomeMes = txtMes.Text;
            int orgao = Convert.ToInt32(txtOrgao.Text);
            string nomeOrgao = txtNomeOrgao.Text;
            string sigla = txtSigla.Text;
            int aprovadas = Convert.ToInt32(txtAprovadas.Text);
            int distribuidas = Convert.ToInt32(txtDistribuidas.Text);
            int ocupadas = Convert.ToInt32(txtOcupadas.Text);
            int vagasDesocupadas = Convert.ToInt32(aprovadas - ocupadas);
            TB_VAGAS_ORGAO vo = new TB_VAGAS_ORGAO()
            {
                NOME_MES = nomeMes,
                ORGAO = orgao,
                NOME_ORGAO = nomeOrgao,
                SIGLA_ORGAO = sigla,
                APROVADA = aprovadas,
                DISTRIBUIDA = distribuidas,
                OCUPADA = ocupadas,
                VAGAS = vagasDesocupadas
            };
            dbcargosvagosEntities contextVagas = new dbcargosvagosEntities();

            string valor = Request.QueryString["orgao"];

            if (String.IsNullOrEmpty(valor))
            {
                contextVagas.TB_VAGAS_ORGAO.Add(vo);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_VAGAS_ORGAO vagas = contextVagas.TB_VAGAS_ORGAO.First(v => v.ORGAO == id);
                vagas.NOME_MES = vo.NOME_MES;
                vagas.ORGAO = vo.ORGAO;
                vagas.NOME_ORGAO = vo.NOME_ORGAO;
                vagas.SIGLA_ORGAO = vo.SIGLA_ORGAO;
                vagas.APROVADA = vo.APROVADA;
                vagas.DISTRIBUIDA = vo.DISTRIBUIDA;
                vagas.OCUPADA = vo.OCUPADA;
                vagas.VAGAS = vo.VAGAS;
                lblmsg.Text = "Registro Alterado";
            }
            contextVagas.SaveChanges();
        }

        private void Clear()
        {
            txtMes.Text = "";
            txtOrgao.Text = "";
            txtNomeOrgao.Text = "";
            txtSigla.Text = "";
            txtAprovadas.Text = "";
            txtDistribuidas.Text = "";
            txtOcupadas.Text = "";
            txtMes.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["orgao"];
            int orgao = 0;
            TB_VAGAS_ORGAO vagas = new TB_VAGAS_ORGAO();


            if (!String.IsNullOrEmpty(valor))
            {
                dbcargosvagosEntities contextCamisetas = new dbcargosvagosEntities();
                orgao = Convert.ToInt32(valor);
                vagas = contextCamisetas.TB_VAGAS_ORGAO.First(v => v.ORGAO == orgao);

                txtMes.Text = vagas.NOME_MES;
                txtOrgao.Text = vagas.ORGAO.ToString();
                txtOrgao.ReadOnly = true;
                txtNomeOrgao.Text = vagas.NOME_ORGAO;
                txtSigla.Text = vagas.SIGLA_ORGAO;
                txtAprovadas.Text = vagas.APROVADA.ToString();
                txtDistribuidas.Text = vagas.DISTRIBUIDA.ToString();
                txtOcupadas.Text = vagas.OCUPADA.ToString();
            }
        }
    }
}
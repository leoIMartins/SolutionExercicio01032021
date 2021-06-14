<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Vagas.aspx.cs" Inherits="AppGerenciarCargosVagos.Vagas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>
    <% if (!String.IsNullOrEmpty(lblmsg.Text))
        {%>
    <div class="alert alert-success">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong>
    </div>
    <%} %>
    <br />
    <form id="form1" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Cadastrar Vagas</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>

        <div class="form-group">
            <label for="mes">Mês:</label>
            <asp:TextBox class="form-control" name="txtMes" ID="txtMes" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="orgao">Número do Orgão:</label>
            <asp:TextBox class="form-control" name="txtOrgao" ID="txtOrgao" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="nome_orgao">Nome do orgão:</label>
            <asp:TextBox class="form-control" name="txtNomeOrgao" ID="txtNomeOrgao" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="sigla_orgao">Sigla:</label>
            <asp:TextBox class="form-control" name="txtSigla" ID="txtSigla" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="aprovadas">Vagas aprovadas:</label>
            <asp:TextBox class="form-control" name="txtAprovadas" ID="txtAprovadas" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="distribuidas">Vagas distribuídas:</label>
            <asp:TextBox class="form-control" name="txtDistribuidas" ID="txtDistribuidas" runat="server">
            </asp:TextBox>
        </div>
        <div class="form-group">
            <label for="distribuidas">Vagas ocupadas:</label>
            <asp:TextBox class="form-control" name="txtOcupadas" ID="txtOcupadas" runat="server">
            </asp:TextBox>
        </div>
        <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar"
            OnClick="btnCadastrar_Click" />
    </form>

</asp:Content>

<%@ Page Title="Orçamento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orcamento.aspx.cs" Inherits="Orcamento.Orcamento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Página responsável por manter orçamentos</h3>
    <asp:HiddenField ID="IdH" runat="server" />
    <br />
    <h4>Data de Início: </h4>
    <asp:TextBox ID="TxtDtInicio" runat="server" Width="400px"></asp:TextBox>
    <h4>Data de Fim: </h4>
    <asp:TextBox ID="TxtDtFim" runat="server" Width="400px"></asp:TextBox>
    <h4>Descrição: </h4>
    <asp:TextBox ID="TxtDescricao" runat="server" Width="400px"></asp:TextBox>
    <h4>Título: </h4>
    <asp:TextBox ID="TxtTitulo" runat="server" Width="400px"></asp:TextBox>
    <h4>Módulo:</h4>
    <asp:DropDownList ID="DdlModulo" runat="server" DataSourceID="Modulo" DataTextField="id" DataValueField="id"></asp:DropDownList>
    <asp:SqlDataSource ID="Modulo" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionSQLServer %>" SelectCommand="SELECT * FROM [TB_MODULO]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="LblMsg" runat="server"></asp:Label>
    <br />
    <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" Width="68px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" Width="68px" />
    <br />
    <br />

    <asp:GridView ID="GVOrcamento" runat="server" GridLines="Vertical" AutoGenerateColumns="False" OnRowCommand="GVOrcamento_RowCommand" class="table table-striped">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="dtinicio" HeaderText="Data de Início" />
            <asp:BoundField DataField="dtfim" HeaderText="Data de Fim" />
            <asp:BoundField DataField="qtddias" HeaderText="Quantidade de Dias" />
            <asp:BoundField DataField="descricao" HeaderText="Descrição" />
            <asp:BoundField DataField="titulo" HeaderText="Título" />
            <asp:BoundField DataField="modulo" HeaderText="Módulo" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Alterar" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" ShowHeader="True" Text="Excluir" />
        </Columns>
    </asp:GridView>
</asp:Content>

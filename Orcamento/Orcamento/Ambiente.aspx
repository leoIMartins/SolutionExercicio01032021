<%@ Page Title="Ambiente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ambiente.aspx.cs" Inherits="Orcamento.Ambiente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Página responsável por manter ambientes<asp:HiddenField ID="IdH" runat="server" />
    </h3>
    <br />
    <h4>Descrição: </h4>
    <asp:TextBox ID="TxtDescricao" runat="server" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="LblMsg" runat="server"></asp:Label>
    <br />
    <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" Width="68px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" Width="68px" />
    <br />
    <br />

    <asp:GridView ID="GVAmbiente" runat="server" GridLines="Vertical" AutoGenerateColumns="False" OnRowCommand="GVAmbiente_RowCommand" class="table table-striped">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="descricao" HeaderText="Descrição" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Alterar" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" ShowHeader="True" Text="Excluir" />
        </Columns>
    </asp:GridView>
</asp:Content>

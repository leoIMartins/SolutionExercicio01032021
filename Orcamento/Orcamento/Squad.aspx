<%@ Page Title="Squad" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Squad.aspx.cs" Inherits="Orcamento.Squad" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Página responsável por manter squads</h3>
    <asp:HiddenField ID="IdH" runat="server" />
    <br />
    <h4>Nome: </h4>
    <asp:TextBox ID="TxtNome" runat="server" Width="400px"></asp:TextBox>
    <br />
    <br />
    <h4>Quantidade de pessoas: </h4>
    <asp:TextBox ID="TxtQtdPessoas" runat="server" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="LblMsg" runat="server"></asp:Label>
    <br />
    <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" Width="68px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" Width="68px" />
    <br />
    <br />

    <asp:GridView ID="GVSquad" runat="server" GridLines="Vertical" AutoGenerateColumns="False" OnRowCommand="GVSquad_RowCommand" class="table table-striped">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nome" HeaderText="Nome" />
            <asp:BoundField DataField="qtdpessoas" HeaderText="Quantidade de Pessoas" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Alterar" />
            <asp:ButtonField ButtonType="Button" CommandName="Excluir" ShowHeader="True" Text="Excluir" />
        </Columns>
    </asp:GridView>
</asp:Content>

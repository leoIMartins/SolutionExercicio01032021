<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Espotifai.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:grey">
    <form id="form1" runat="server">
        <table style="width:auto">
            <tr>
                <td class="auto-style4">
                    <h1>Música</h1>
                </td>
                <td class="auto-style1">
                    <asp:HiddenField ID="IdH" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Nome:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtNomeMusica" runat="server" Width="402px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Duração: </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtDuracao" runat="server" Width="402px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Compositor:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCompositor" runat="server" Width="402px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Gênero:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtGenero" runat="server" Width="402px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Álbum:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DdlAlbum" runat="server" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="nome">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionSQLServer %>" SelectCommand="SELECT * FROM [TB_ALBUM]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style1">
                    
                    <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" Width="68px" />
                &nbsp;&nbsp;
                    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" Width="68px" />
                    
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView style="width:60%" ID="GVMusica" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" AutoGenerateColumns="False" CssClass="auto-style6" OnRowCommand="GVMusica_RowCommand">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="duracao" HeaderText="Duração" />
                            <asp:BoundField DataField="compositor" HeaderText="Compositor" />
                            <asp:BoundField DataField="genero" HeaderText="Genero" />
                            <asp:BoundField DataField="album" HeaderText="Album" />
                            <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Alterar" />
                            <asp:ButtonField ButtonType="Button" CommandName="Excluir" ShowHeader="True" Text="Excluir" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>

    </form>
</body>
</html>

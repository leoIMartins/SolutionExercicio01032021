<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Espotifai.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:auto">
            <tr>
                <td class="auto-style4">
                    ******Álbum******
                </td>
                <td class="auto-style1">
                    <asp:HiddenField ID="IdH" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Nome:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtNomeAlbum" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Lançamento: </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtLancamento" runat="server" Width="398px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Gravadora:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtGravadora" runat="server" Width="396px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Artista:</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DdlArtista" runat="server" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="nome">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionSQLServer %>" SelectCommand="SELECT * FROM [TB_ARTISTA]"></asp:SqlDataSource>
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
        <asp:GridView style="width:60%" ID="GVAlbum" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" AutoGenerateColumns="False" CssClass="auto-style6" OnRowCommand="GVAlbum_RowCommand">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="lancamento" HeaderText="Lançamento" />
                            <asp:BoundField DataField="gravadora" HeaderText="Gravadora" />
                            <asp:BoundField DataField="artista" HeaderText="Artista" />
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

        <br />
        <asp:Label ID="LblAlerta" runat="server" Enabled="False" ForeColor="Red" Text="É necessário cadastrar um álbum para prosseguir!" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="BtnMusica" runat="server" CssClass="auto-style8" OnClick="BtnMusica_Click" Text="Adicionar Musica" />

    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Espotifai.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 295px;
        }
        .auto-style4 {
            height: 26px;
            width: 14px;
        }
        .auto-style6 {
            width: 84px;
            margin-top: 0px;
        }
        .auto-style7 {
            width: 14px;
        }
        .auto-style8 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:auto">
            <tr>
                <td class="auto-style4">
                    ******Artista******
                </td>
                <td class="auto-style1">
                    <asp:HiddenField ID="IdH" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Nome:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtNome" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Integrantes: </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtIntegrantes" runat="server" Width="398px"></asp:TextBox>
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
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style1">
                    
                </td>
            </tr>
        </table>
        <asp:GridView style="width:60%" ID="GVArtista" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" AutoGenerateColumns="False" CssClass="auto-style6" OnRowCommand="GVArtista_RowCommand">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="integrantes" HeaderText="Integrantes" />
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
        <asp:Label ID="LblAlerta" runat="server" Enabled="False" ForeColor="Red" Text="É necessário cadastrar um artista para prosseguir!" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="BtnAlbum" runat="server" CssClass="auto-style8" OnClick="BtnAlbum_Click" Text="Adicionar Album" />

    </form>
</body>
</html>

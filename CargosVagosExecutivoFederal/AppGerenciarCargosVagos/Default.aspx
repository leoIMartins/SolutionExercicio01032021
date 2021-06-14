<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppGerenciarCargosVagos.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function MostrarPopupMensagem() {
        $("#modalMsg").modal('show');
        }
        function EsconderPopupDados() {
        $("#modalDados").modal('hide');
        }
    </script>
    <div class="modal fade" id="modalMsg">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">

                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>

                    <h4 class="modal-title" id="h1" runat="server">Modal title</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <label id="lblMsgPopup" runat="server">
                        </label>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Ok</button>
                </div>
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:GridView ID="GVVagas" runat="server" CellPadding="4" CssClass="table" ForeColor="#333333"
            GridLines="None" AutoGenerateColumns="False" OnRowCommand="GVVagas_RowCommand">
            <alternatingrowstyle backcolor="White" />
            <editrowstyle backcolor="#2461BF" />
            <footerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
            <headerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
            <pagerstyle backcolor="#2461BF" forecolor="White" horizontalalign="Center" />
            <rowstyle backcolor="#EFF3FB" />
            <selectedrowstyle backcolor="#D1DDF1" font-bold="True" forecolor="#333333" />
            <sortedascendingcellstyle backcolor="#F5F7FB" />
            <sortedascendingheaderstyle backcolor="#6D95E1" />
            <sorteddescendingcellstyle backcolor="#E9EBEF" />
            <sorteddescendingheaderstyle backcolor="#4870BE" />
            <columns>
            <asp:BoundField DataField="NOME_MES" HeaderText="Mês" />
            <asp:BoundField DataField="ORGAO" HeaderText="Orgão" />
            <asp:BoundField DataField="NOME_ORGAO" HeaderText="Nome do Orgão" />
                <asp:BoundField DataField="SIGLA_ORGAO" HeaderText="Sigla" />
                <asp:BoundField DataField="APROVADA" HeaderText="Aprovadas" />
                <asp:BoundField DataField="DISTRIBUIDA" HeaderText="Distribuídas" />
                <asp:BoundField DataField="OCUPADA" HeaderText="Ocupadas" />
                <asp:BoundField DataField="VAGAS" HeaderText="Vagas" />
            <asp:TemplateField HeaderText="Ações">
            <ItemTemplate>
            <asp:LinkButton runat="server" ID="btnAlterarMidia" CommandName="ALTERAR"
            CommandArgument='<%# Eval("ORGAO") %>' CssClass="btn btn btn-info" Text="Alterar" />
            <asp:LinkButton runat="server" ID="btnExcluirMidia" CommandName="EXCLUIR"
            CommandArgument='<%# Eval("ORGAO") %>' CssClass="btn btn btn-primary" Text="Excluir" />
            </ItemTemplate>
            </asp:TemplateField>
            </columns>
        </asp:GridView>
    </form>
</asp:Content>

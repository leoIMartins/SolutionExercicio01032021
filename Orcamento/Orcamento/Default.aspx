<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Orcamento._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Orçamento</h1>
        <p class="lead">Cadastre o orçamento do seu projeto neste sistema top que acabou de ser desenvolvido!!!
            Mas antes, confira à baixo os pré-requisitos
        </p>
        <p><a href="https://localhost:44335/Orcamento" class="btn btn-primary btn-lg">Cadastrar Orçamento &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ambiente</h2>
            <p>
                Antes de tudo, é necessário cadastrar um ambiente. Clique no botão à baixo e vá para a página de cadastro.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44335/Ambiente">Cadastrar Ambiente &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Squad</h2>
            <p>
                Outro pré-requisito é o cadastro de uma squad. Clique no botão à baixo e vá para a página de cadastro.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44335/Squad">Cadastrar Squad &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Módulo</h2>
            <p>
                Após o cadastro de um ambiente e uma squad, você já pode cadastrar um módulo. Clique no botão à baixo e vá para a página de cadastro.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44335/Modulo">Cadastrar Módulo &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

<%@ Page Title="" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Zoo.Animales.Eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Eliminar</h2>

    <h3>¿Estas seguro que desea eliminar este animal?</h3>
    <div>
        <h4>Animal</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>Nombre
            </dt>

            <dd>
                <asp:Label ID="Nombre" runat="server" />
            </dd>

            <dt>Edad
            </dt>

            <dd>
                <asp:Label ID="Edad" runat="server" />
            </dd>

            <dt>País Origen
            </dt>

            <dd>
                <asp:Label ID="PaisOrigen" runat="server" />
            </dd>

            <dt>Especie
            </dt>

            <dd>
                <asp:Label ID="Especie" runat="server" />
            </dd>

            <dt>Subespecie
            </dt>

            <dd>
                <asp:Label ID="Subespecie" runat="server" />
            </dd>

            <dt>Costumbres Alimentícias
            </dt>

            <dd>
                <asp:Label ID="CostumbresAlimenticias" runat="server" />
            </dd>

            <dt>Tipo
            </dt>

            <dd>
                <asp:Label ID="Tipo" runat="server" />
            </dd>

        </dl>
        <div class="form-actions no-color">
            <asp:Button ID="EliminarBtn" Text="Eliminar" runat="server" CssClass="btn btn-default" OnClick="Eliminar_Click" />
            <a runat="server" href="~/Animales/">Regresar</a>
        </div>
    </div>
</asp:Content>

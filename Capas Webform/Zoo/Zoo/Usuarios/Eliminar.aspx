<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Zoo.Usuarios.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Eliminar</h2>

    <h3>¿Estas seguro que desea eliminar este usuario?</h3>
    <div>
        <h4>Usuario</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>Nombre
            </dt>

            <dd>
                <asp:Label ID="Nombre" runat="server" />
            </dd>
        </dl>
        <div class="form-actions no-color">
            <asp:Button ID="EliminarBtn" Text="Eliminar" runat="server" CssClass="btn btn-default" OnClick="Eliminar_Click" />
            <a runat="server" href="~/Usuarios/">Regresar</a>
        </div>
    </div>
</asp:Content>

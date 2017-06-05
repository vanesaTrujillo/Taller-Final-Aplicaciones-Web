<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zoo.Usuarios.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="UsuariosODS" runat="server" DataObjectTypeName="Entidades.Usuarios" TypeName="Negocio.UsuariosController" SelectMethod="Consultar"></asp:ObjectDataSource>

    <h2>Usuarios</h2>
    <p>
        <a runat="server" href="~/Usuarios/Crear">Nuevo</a>
    </p>
    <asp:GridView ID="UsuariosGV"
        DataSourceID="UsuariosODS"
        AutoGenerateColumns="False"
        EmptyDataText="No hay datos disponibles."
        AllowPaging="True"
        runat="server" DataKeyNames="Id" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Nombre"
                HeaderText="Nombre" />
            <asp:HyperLinkField HeaderText="Editar" Text="Editar"
                DataNavigateUrlFields="Id"
                DataNavigateUrlFormatString="~/Usuarios/Editar.aspx?Id={0}" ItemStyle-Width="80" />
            <asp:HyperLinkField HeaderText="Eliminar" Text="Eliminar"
                DataNavigateUrlFields="Id"
                DataNavigateUrlFormatString="~/Usuarios/Eliminar.aspx?Id={0}" ItemStyle-Width="80" />
        </Columns>
    </asp:GridView>
</asp:Content>

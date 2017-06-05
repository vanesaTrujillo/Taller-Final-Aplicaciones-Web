<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zoo.Enfermeria.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="EnfermeriaODS" runat="server" DataObjectTypeName="Entidades.Enfermeria" TypeName="Negocio.EnfermeriaController" SelectMethod="Consultar"></asp:ObjectDataSource>

    <h2>Enfermería</h2>
    <p>
        <a runat="server" href="~/Enfermeria/Crear">Nuevo</a>
    </p>
    <asp:GridView ID="EnfermeriaGV"
        DataSourceID="EnfermeriaODS"
        AutoGenerateColumns="False"
        EmptyDataText="No hay datos disponibles."
        AllowPaging="True"
        runat="server" DataKeyNames="Id" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id"
                HeaderText="Id" Visible="false" />
            <asp:BoundField DataField="Animales.Nombre"
                HeaderText="Animal" />
            <asp:BoundField DataField="FechaIngreso"
                HeaderText="Fecha Ingreso" />
            <asp:BoundField DataField="Diagnostico"
                HeaderText="Diagnóstico" />
        </Columns>
    </asp:GridView>
</asp:Content>

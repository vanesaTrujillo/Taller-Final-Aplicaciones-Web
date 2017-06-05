<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zoo.Reporte.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="ReporteODS" runat="server" DataObjectTypeName="Entidades.Reporte" TypeName="Negocio.ReporteController" SelectMethod="Consultar"></asp:ObjectDataSource>

    <h2>Reporte</h2>
    <p>
        <asp:LinkButton ID="ExportarLink" Text="Exportar" OnClick="Exportar_Click" runat="server" />
    </p>
    <asp:GridView ID="ReporteGV"
        DataSourceID="ReporteODS"
        AutoGenerateColumns="False"
        EmptyDataText="No hay datos disponibles."
        AllowPaging="True"
        runat="server" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Nombre"
                HeaderText="Nombre" />
            <asp:BoundField DataField="Edad"
                HeaderText="Edad" />
            <asp:BoundField DataField="FechaIngreso"
                HeaderText="Fecha Ingreso" />
            <asp:BoundField DataField="Diagnostico"
                HeaderText="Diagnóstico" />
        </Columns>
    </asp:GridView>
</asp:Content>

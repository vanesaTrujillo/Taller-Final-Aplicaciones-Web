<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zoo.Animales.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="AnimalesODS" runat="server" DataObjectTypeName="Entidades.Animales" TypeName="Negocio.AnimalesController" SelectMethod="Consultar"></asp:ObjectDataSource>

    <h2>Animales</h2>
    <p>
        <a runat="server" href="~/Animales/Crear">Nuevo</a>
    </p>
    <asp:GridView ID="AnimalesGV"
        DataSourceID="AnimalesODS"
        AutoGenerateColumns="False"
        EmptyDataText="No hay datos disponibles."
        AllowPaging="True"
        runat="server" DataKeyNames="Id" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" 
                HeaderText="Id" InsertVisible="False" Visible="false" ReadOnly="true"/>
            <asp:BoundField DataField="Nombre" 
                HeaderText="Nombre"/>
            <asp:BoundField DataField="Edad" 
                HeaderText="Edad" />
            <asp:BoundField DataField="PaisOrigen" 
                HeaderText="País Origen" />
            <asp:BoundField DataField="Especie" 
                HeaderText="Especie"/>
            <asp:BoundField DataField="Subespecie" 
                HeaderText="Subespecie" />
            <asp:BoundField DataField="CostumbresAlimenticias" 
                HeaderText="Costumbres Alimentícias"/>
            <asp:BoundField DataField="Tipo" 
                HeaderText="Tipo"/>
            <asp:HyperLinkField HeaderText="Editar" Text="Editar"  
                DataNavigateUrlFields="Id" 
                DataNavigateUrlFormatString="~/Animales/Editar.aspx?Id={0}" ItemStyle-Width="80" />
            <asp:HyperLinkField HeaderText="Eliminar" Text="Eliminar"  
                DataNavigateUrlFields="Id" 
                DataNavigateUrlFormatString="~/Animales/Eliminar.aspx?Id={0}" ItemStyle-Width="80" />
        </Columns>
    </asp:GridView>
</asp:Content>

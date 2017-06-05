<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="Zoo.Enfermeria.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="AnimalesODS" runat="server" DataObjectTypeName="Entidades.Animales" TypeName="Negocio.AnimalesController" SelectMethod="Consultar"></asp:ObjectDataSource>
    <h2>Crear</h2>
    <div class="form-horizontal">
        <h4>Enfermería</h4>
        <hr />
        <div class="form-group">
            <asp:Label Text="Animal" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:DropDownList ID="Animal" runat="server" CssClass="form-control" CausesValidation="true" DataSourceID="AnimalesODS" DataTextField="Nombre" DataValueField="Id">    </asp:DropDownList>
                <asp:Label ID="AnimalValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Diagnóstico" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="Diagnostico" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="200" />
                <asp:Label ID="DiagnosticoValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="CrearBtn" Text="Crear" runat="server" CssClass="btn btn-default" OnClick="Crear_Click" />
            </div>
        </div>
    </div>
    <div>
        <a runat="server" href="~/Animales/">Regresar</a>
    </div>
</asp:Content>

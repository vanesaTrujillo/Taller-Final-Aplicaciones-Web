<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zoo.Usuarios.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <hr />
    <h3>
        <asp:Label ID="Mensaje" CssClass="text-danger" Visible="false" runat="server" />
    </h3>
    <div class="form-group">
        <asp:Label Text="Nombre" runat="server" CssClass="control-label col-md-2" />
        <div class="col-md-10">
            <asp:TextBox ID="Nombre" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="50"></asp:TextBox>
            <asp:Label ID="NombreValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
        </div>
    </div>
    <div class="form-group">
        <asp:Label Text="Contraseña" runat="server" CssClass="control-label col-md-2" />
        <div class="col-md-10">
            <asp:TextBox ID="Contrasena" runat="server" CssClass="form-control" CausesValidation="true" TextMode="Password" MaxLength="150" />
            <asp:Label ID="ContrasenaValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button ID="Ingresar" Text="Ingresar" runat="server" CssClass="btn btn-default" OnClick="Ingresar_Click" />
        </div>
    </div>
</asp:Content>

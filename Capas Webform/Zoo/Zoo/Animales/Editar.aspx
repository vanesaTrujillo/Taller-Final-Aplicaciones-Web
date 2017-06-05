<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Zoo.Animales.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar</h2>
    <div class="form-horizontal">
        <h4>Animal</h4>
        <hr />
        <div class="form-group">
            <asp:Label Text="Nombre" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="Nombre" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="50" />
                <asp:Label ID="NombreValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Edad" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="Edad" runat="server" CssClass="form-control" CausesValidation="true" TextMode="Number" />
                <asp:Label ID="EdadValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="País Origen" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="PaisOrigen" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="50" />
                <asp:Label ID="PaisOrigenValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Especie" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="Especie" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="50" />
                <asp:Label ID="EspecieValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Subespecie" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="Subespecie" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="50" />
                <asp:Label ID="SubespecieValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Constumbres Alimenticias" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:TextBox ID="CostumbresAlimenticias" runat="server" CssClass="form-control" CausesValidation="true" MaxLength="100" />
                <asp:Label ID="CostumbresAlimenticiasValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label Text="Tipo" runat="server" CssClass="control-label col-md-2" />
            <div class="col-md-10">
                <asp:DropDownList ID="Tipo" runat="server" CssClass="form-control" CausesValidation="true">
                    <asp:ListItem Text="Mamífero" />
                    <asp:ListItem Text="Ave" />
                    <asp:ListItem Text="Acuático" />
                </asp:DropDownList>
                <asp:Label ID="TipoValidation" Text="" runat="server" CssClass="text-danger" Visible="false" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="GuardarBtn" Text="Guardar" runat="server" CssClass="btn btn-default" OnClick="Guardar_Click" />
            </div>
        </div>
    </div>
    <div>
        <a runat="server" href="~/Animales/">Regresar</a>
    </div>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarPremio.aspx.cs" Inherits="tp_winform_equipo_12C_2._0_.SeleccionarPremio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seleccionar Premio</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <h2>Selecciona tu Premio</h2>
                <p>Selecciona uno de los premios disponibles para continuar con el registro.</p>
                <div class="form-group">
                    <label for="DropDownListPremios">Premio:</label>
                    <asp:DropDownList ID="DropDownListPremios" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownListPremios_SelectedIndexChanged" AutoPostBack="true" />
                </div>
                <asp:Button ID="ButtonConfirmar" runat="server" Text="Confirmar Selección" CssClass="btn btn-primary" OnClick="ButtonConfirmar_Click" />
                <asp:Label ID="LabelMensaje" runat="server" CssClass="text-danger mt-3" />

                <h3 class="mt-4">Imágenes del Premio</h3>
                <div id="PanelImagenes" runat="server" class="row mt-3"></div>
            </div>
        </div>
    </form>
</body>
</html>

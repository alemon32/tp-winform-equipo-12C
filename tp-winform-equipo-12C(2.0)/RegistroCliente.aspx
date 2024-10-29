<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="tp_winform_equipo_12C_2._0_.RegistroCliente" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Cliente</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <h2>Registro de Cliente</h2>
                <p>Por favor, complete sus datos para participar en la promoción.</p>

                <div class="form-group">
                    <label for="TextBoxDocumento">DNI:</label>
                    <asp:TextBox ID="TextBoxDocumento" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxNombre">Nombre:</label>
                    <asp:TextBox ID="TextBoxNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxApellido">Apellido:</label>
                    <asp:TextBox ID="TextBoxApellido" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxEmail">Email:</label>
                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxDireccion">Dirección:</label>
                    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxCiudad">Ciudad:</label>
                    <asp:TextBox ID="TextBoxCiudad" runat="server" CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label for="TextBoxCP">Código Postal:</label>
                    <asp:TextBox ID="TextBoxCP" runat="server" CssClass="form-control" />
                </div>

                <asp:Button ID="ButtonRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="ButtonRegistrar_Click" />
                <asp:Label ID="LabelMensaje" runat="server" CssClass="text-danger mt-3" />
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>

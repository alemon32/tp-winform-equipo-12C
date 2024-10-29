<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoucherForm.aspx.cs" Inherits="tp_winform_equipo_12C_2._0_.VoucherForm" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ingreso de Voucher</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <div class="container mt-5">
        <h2 class="text-center">Ingresar Código de Voucher</h2>
        <form runat="server">
            <div class="form-group">
                <label for="TextBoxCodigoVoucher">Código del Voucher</label>
                <asp:TextBox ID="TextBoxCodigoVoucher" CssClass="form-control" runat="server" placeholder="XXXXXXXXXXXXXXXXXXXX" />
            </div>
            <asp:Button ID="ButtonValidarCodigo" runat="server" CssClass="btn btn-primary" Text="Siguiente" OnClick="ButtonValidarCodigo_Click"/>
            <asp:Label ID="LabelMensaje" CssClass="text-danger mt-3" runat="server" Text=""></asp:Label>
        </form>
    </div>
</body>
</html>


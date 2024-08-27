<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Tp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card customCard">
            <div class="card-body">
                <div class="pt-2"></div>
                <h5 class="card-title">Tp2 Eliminar</h5>
                <h3>Conexión a MYSQL</h3>
                <div class="pt-2"></div>
            </div>
        </div>
        <hr />
        <div class="container-fluid">
            <p runat="server" id="msn"></p>

            <asp:Button ID="cmdConfirm" Text="Confirm" runat="server" OnClick="cmdConfirm_Click" />
            <asp:Button ID="cmdCancel" Text="Cancel" runat="server" OnClick="cmdCancel_Click" />
        </div>
    </form>
</body>
</html>

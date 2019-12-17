<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyNavidad.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPass" type="password" placeholder="password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label" BorderColor="#FFFF99" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="ButtonLogin" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>

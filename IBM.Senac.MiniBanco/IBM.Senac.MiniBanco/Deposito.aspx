<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deposito.aspx.cs" Inherits="IBM.Senac.MiniBanco.Deposito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="display: inline-block">
    <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Deposito"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Selecione um Cliente: "></asp:Label>
            <asp:DropDownList ID="DropDownListContas" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Valor: "></asp:Label>
            <asp:TextBox ID="TextBoxValor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonDepositar" runat="server" Text="Depositar" />
        </p>
    </form>
</body>
</html>

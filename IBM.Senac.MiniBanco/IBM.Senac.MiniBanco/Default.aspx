<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IBM.Senac.MiniBanco.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="MINI BANCO"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="Cadastro" runat="server" OnClick="Cadastro_Click">Cadastro</asp:LinkButton>&nbsp;
        <asp:LinkButton ID="Deposito" runat="server" OnClick="Deposito_Click">Deposito</asp:LinkButton>&nbsp; 
        <asp:LinkButton ID="Saque" runat="server" OnClick="Saque_Click">Saque</asp:LinkButton>&nbsp;
        <asp:LinkButton ID="Transferencia" runat="server" OnClick="Transferencia_Click">Transferência</asp:LinkButton>   
    </form>
</body>
</html>

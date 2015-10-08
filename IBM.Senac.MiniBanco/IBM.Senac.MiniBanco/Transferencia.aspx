<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="IBM.Senac.MiniBanco.Transferencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 229px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Tranferência"></asp:Label>
        <p style="display: inline-block">
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Tranferir de: "></asp:Label>
            <asp:DropDownList ID="DropDownListContas" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Para: "></asp:Label>
            <asp:DropDownList ID="DropDownListContas2" runat="server" style="margin-bottom: 0px">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Valor: "></asp:Label>
            <asp:TextBox ID="TextBoxValor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonTranferir" runat="server" Text="Tranferir" />
        </p>
    </form>
</body>
</html>

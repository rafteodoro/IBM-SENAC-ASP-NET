<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieTeste.aspx.cs" Inherits="LabelDataHora.CookieTeste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="labelResposta" runat="server"></asp:Label>
        <p>
            <asp:Button ID="ButtonLerCookie" runat="server" Text="Ler Cookie"/>
        </p>
        <asp:Label ID="labelHoraSessao" runat="server"></asp:Label>
    </form>
</body>
</html>

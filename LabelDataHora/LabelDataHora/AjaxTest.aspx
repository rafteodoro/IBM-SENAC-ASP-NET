<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxTest.aspx.cs" Inherits="LabelDataHora.AjaxTest" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="LabelTexto" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="ButtonCalcular" runat="server" Text="Calcular" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="LabelTexto2" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="ButtonCalcular2" runat="server" Text="Calcular"/>
            </ContentTemplate>
        </asp:UpdatePanel>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

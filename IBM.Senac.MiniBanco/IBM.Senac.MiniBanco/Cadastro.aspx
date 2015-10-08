<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="IBM.Senac.MiniBanco.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Cadastro de Contas"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Número: "></asp:Label>
            <asp:TextBox ID="TextBoxNumero" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Saldo Inicial: "></asp:Label>
            <asp:TextBox ID="TextBoxSaldoInicial" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Tipo de Conta: "></asp:Label>
            <asp:CheckBoxList ID="CheckBoxListTipoConta" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Selected="True" Value="C">Corrente</asp:ListItem>
                <asp:ListItem Value="P">Poupanca</asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <p>
            <asp:Button ID="ButtonSalvar" runat="server" Text="Salvar" />
        </p>
        <asp:ListBox ID="ListBoxClientes" runat="server"></asp:ListBox>
    </form>
</body>
</html>

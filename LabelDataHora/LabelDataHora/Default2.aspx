<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="LabelDataHora.Default" %>

<%@ Register Src="~/LabelText.ascx" TagPrefix="uc1" TagName="LabelText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teste</title>
</head>
<body>
    <form id="form1" runat="server" style="border-width: thin; border-style: double; background-color: #C0C0C0; text-align: left; display: inline-block;">
    <div>
    
    </div>
        <asp:Label ID="label1" runat="server" Text="Escolha a conta a pagar:"></asp:Label>
                <asp:RadioButtonList ID="radioButtonListTipoConta" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Value="Agua" Selected="True">&#193;gua</asp:ListItem>
            <asp:ListItem>Luz</asp:ListItem>
            <asp:ListItem Value="Gas">Gás</asp:ListItem>
        </asp:RadioButtonList>
        <p>
        <asp:Label ID="label2" runat="server" Text="Digite o consume aferido:"></asp:Label>

        <asp:TextBox ID="textBoxConsumoAferido" runat="server" Text="" Width="300px" BorderColor="Black" MaxLength="10" Height="16px"></asp:TextBox>
            <asp:Label ID="labelErroConsumoAferido" runat="server" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Label ID="label3" runat="server" Text="Opção de Desconto:"></asp:Label>

            <asp:DropDownList ID="DropDownListDesconto" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="N">Não</asp:ListItem>
                <asp:ListItem Value="S">Sim</asp:ListItem>
            </asp:DropDownList>

        </p>
        <asp:Button ID="ButtonCalcular" runat="server" OnClick="ButtonCalcular_Click" Text="Calcular" />
        <p>
            <asp:Label ID="labelResultado" runat="server"></asp:Label>
        </p>
        <p>
            <uc1:LabelText runat="server" ID="LabelText" />
                <asp:Button ID="buttonValidar" runat="server" OnClick="buttonValidar_Click" Text="Validar" />
        </p>
    </form>
    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="tp4_prog3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 75%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 110px;
        }
        .auto-style4 {
            height: 26px;
            width: 80px;
        }
        .auto-style5 {
            height: 26px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp; IdProducto:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlFiltroProducto" runat="server">
                            <asp:ListItem Value="=">Igual a</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="txtFiltroProducto" runat="server" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp; IdCategoria:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlFiltroCategoria" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="txtFiltroCategoria" runat="server" Width="348px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
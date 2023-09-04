<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="tp4_prog3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 100px;
        }
        .auto-style6 {
            width: 115px;
            height: 55px;
        }
        .auto-style7 {
            width: 100px;
            height: 55px;
        }
        .auto-style8 {
            height: 55px;
        }
        .auto-style9 {
            margin-left: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="IdProducto:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlFiltroProducto" runat="server">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFiltroProducto" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="IdCategoria:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlFiltroCategoria" runat="server">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFiltroCategoria" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style6" style="text-align: right">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnQuitarFiltro" runat="server" CssClass="auto-style9" Text="Quitar filtro" OnClick="btnQuitarFiltro_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
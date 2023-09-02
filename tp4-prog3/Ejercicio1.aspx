<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="tp4_prog3.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style6 {
            height: 50px;
        }
        .auto-style7 {
            width: 130px;
            height: 50px;
        }
        .auto-style8 {
            width: 130px;
        }
        .auto-style9 {
            width: 115px;
            height: 50px;
        }
        .auto-style10 {
            width: 115px;
        }
        .auto-style11 {
            width: 115px;
            height: 29px;
        }
        .auto-style12 {
            width: 130px;
            height: 29px;
        }
        .auto-style13 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Font-Underline="True" Text="DESTINO INICIO"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlProvinciaInicio" runat="server">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidadInicio" runat="server">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" Font-Underline="True" Text="DESTINO FINAL"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProvinciaFinal" runat="server">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlLocalidadFinal" runat="server">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

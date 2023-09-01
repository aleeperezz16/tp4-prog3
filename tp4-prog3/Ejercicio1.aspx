<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="tp4_prog3.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 156px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            width: 100px;
        }
      
        .auto-style6 {
            width: 100px;
            height: 26px;
        }
        .auto-style7 {
            width: 156px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7"><u>DESTINO INICIO</u></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style2"><b>PROVINCIA</b>:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlProvinciaInicio" runat="server" Height="25px" Width="132px">
                    <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style2"><b>LOCALIDAD:</b></td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="132px">
                    <asp:ListItem>--Seleccionar--</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>

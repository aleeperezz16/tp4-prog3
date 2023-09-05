<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3a.aspx.cs" Inherits="tp4_prog3.Ejercicio3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 117px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Seleccionar tema:</td>
                    <td>
                        <asp:DropDownList ID="ddlTemas" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lbtnVerLibros" runat="server" OnClick="lbtnVerLibros_Click">Ver Libros</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

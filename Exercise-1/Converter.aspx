<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="Exercise_1.Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Хувиргах утгаа оруул:</td>
                <td>
                    <asp:TextBox ID="sizeTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="minusButton" runat="server" Text="10 хасах" />
                    <asp:Button ID="addButton" runat="server" Text="10 нэмэх" />
                </td>
            </tr>
            <tr>
                <td>Хувиргах төрлөө сонго:<br />
                </td>
                <td>
                    <asp:ListBox ID="convertSelectListBox" runat="server">
                        <asp:ListItem>Инчийг сантметерт хувиргах</asp:ListItem>
                        <asp:ListItem>Бээрийг километетрт хувиргах</asp:ListItem>
                        <asp:ListItem>Паундыг граммд хувиргах</asp:ListItem>
                        <asp:ListItem>Морины хүчийг ватт-д хувиргах</asp:ListItem>
                    </asp:ListBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Үр дүн:<asp:Label ID="resultLabel" runat="server" Text="resultLabel"></asp:Label>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="convertButton" runat="server" Text="Хувиргах" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

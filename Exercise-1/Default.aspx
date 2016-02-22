<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_1.Default" %>

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
                <td>First name:</td>
                <td>
                    <asp:TextBox ID="firstNameText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Last name:</td>
                <td>
                    <asp:TextBox ID="lastNameText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Gender:</td>
                <td>
                    <asp:RadioButton ID="maleRadioButton" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                    <asp:RadioButton ID="femaleRadioButton" runat="server" Text="Female" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>E-mail address:</td>
                <td>
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Re-enter password</td>
                <td>
                    <asp:TextBox ID="rePasswordText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Company:</td>
                <td>
                    <asp:TextBox ID="companyText" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Address Line 1:</td>
                <td>
                    <asp:TextBox ID="address1Text" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Address Line 2:</td>
                <td>
                    <asp:TextBox ID="address2Text" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>City:</td>
                <td>
                    <asp:TextBox ID="cityText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>State/Province:</td>
                <td>
                    <asp:TextBox ID="stateText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Zip/Postal code:</td>
                <td>
                    <asp:TextBox ID="zipText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Country:</td>
                <td>
                    <asp:DropDownList ID="countryDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Day Phone:</td>
                <td>
                    <asp:TextBox ID="phoneText" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

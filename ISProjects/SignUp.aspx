<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Exercise_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 171px;
        }
        .auto-style3 {
            width: 171px;
            height: 14px;
        }
        .auto-style4 {
            height: 14px;
        }
        .auto-style5 {
            width: 139px;
        }
        .auto-style6 {
            height: 14px;
            width: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First name:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="firstNameText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="fnameValidator" runat="server" ControlToValidate="firstNameText" ErrorMessage="First name must be filled in"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Last name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="lastNameText" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="lnameValidator" runat="server" ErrorMessage="last name  must be filled in" ControlToValidate="lastNameText"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">Gender:</td>
                <td class="auto-style5">
                    <asp:RadioButton ID="maleRadioButton" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                    <asp:RadioButton ID="femaleRadioButton" runat="server" Text="Female" OnCheckedChanged="femaleRadioButton_CheckedChanged" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">E-mail address:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Email  must be filled in" ControlToValidate="emailText" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="mailRegularExpressionValidator" runat="server" ControlToValidate="emailText" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="passValidator" runat="server" ErrorMessage=" Password must be filled in" ControlToValidate="passwordText"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Re-enter password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="rePasswordText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="repassValidator" runat="server" ErrorMessage="Re-password  must be filled in" ControlToValidate="rePasswordText"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordText" ErrorMessage="CompareValidator"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Company:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="companyText" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="compValidator" runat="server" ErrorMessage="Company must be filled in" ControlToValidate="companyText"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Line 1:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="address1Text" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="addr1Validator" runat="server" ErrorMessage="Address  must be filled in" ControlToValidate="address1Text"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Line 2:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="address2Text" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="addr2Validator" runat="server" ErrorMessage="Address 2  must be filled in" ControlToValidate="address2Text"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">City:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="cityText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="cityValidator" runat="server" ErrorMessage="City must be filled in" ControlToValidate="cityText"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">State/Province:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="stateText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="stateValidator" runat="server" ErrorMessage="State must be filled in" ControlToValidate="stateText"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Zip/Postal code:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="zipText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="zipValidator" runat="server" ErrorMessage="Zip must be filled in" ControlToValidate="zipText"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="zipRegularExpressionValidator" runat="server" ControlToValidate="zipText" ErrorMessage="RegularExpressionValidator" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Country:</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="countryDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Day Phone:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="phoneText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="phoneValidator" runat="server" ErrorMessage="Phone must be filled in" ControlToValidate="phoneText"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="phoneRegularExpressionValidator" runat="server" ControlToValidate="phoneText" ErrorMessage="RegularExpressionValidator" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
        <asp:CheckBox ID="submitCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="I understand that submitting this information will flood my inbox with junkmail" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Button ID="signUpButton" runat="server" Text="Sign up!" OnClick="signUpButton_Click" />
        </p>
        <asp:ValidationSummary ID="signUpSummary" runat="server" ShowMessageBox="True" />
    </form>
</body>
</html>

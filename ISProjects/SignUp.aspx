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
                    <asp:RequiredFieldValidator ID="fnameValidator" runat="server" ControlToValidate="firstNameText" ErrorMessage="First name must be filled in" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Last name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="lastNameText" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="lnameValidator" runat="server" ErrorMessage="last name  must be filled in" ControlToValidate="lastNameText" ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Email  must be filled in" ControlToValidate="emailText" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="passValidator" runat="server" ErrorMessage=" Password must be filled in" ControlToValidate="passwordText" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Re-enter password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="rePasswordText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="repassValidator" runat="server" ErrorMessage="Re-password  must be filled in" ControlToValidate="rePasswordText" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="rePasswordText" ErrorMessage="CompareValidator" ControlToValidate="passwordText"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Company:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="companyText" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="compValidator" runat="server" ErrorMessage="Company must be filled in" ControlToValidate="companyText" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Line 1:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="address1Text" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="addr1Validator" runat="server" ErrorMessage="Address  must be filled in" ControlToValidate="address1Text" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Line 2:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="address2Text" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="addr2Validator" runat="server" ErrorMessage="Address 2  must be filled in" ControlToValidate="address2Text" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">City:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="cityText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="cityValidator" runat="server" ErrorMessage="City must be filled in" ControlToValidate="cityText" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">State/Province:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="stateText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="stateValidator" runat="server" ErrorMessage="State must be filled in" ControlToValidate="stateText" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Zip/Postal code:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="zipText" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="zipValidator" runat="server" ErrorMessage="Zip must be filled in" ControlToValidate="zipText" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="zipRegularExpressionValidator" runat="server" ControlToValidate="zipText" ErrorMessage="Example 11111-1111" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
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
                    <asp:RequiredFieldValidator ID="phoneValidator" runat="server" ErrorMessage="Phone must be filled in" ControlToValidate="phoneText" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="phoneRegularExpressionValidator" runat="server" ControlToValidate="phoneText" ErrorMessage="Example 976-9999999" ValidationExpression="\d{3}(-\d{8})?"></asp:RegularExpressionValidator>
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
        <asp:CheckBox ID="submitCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Please check the box indicating that you will receive floods of junkmail"/>
        <span runat="server" id="_understandValidator" controltovalidate="_understand" errormessage="Please check the box indicating that you will receive floods of junkmail" evaluationfunction="RequiredCheckBoxValidatorEvaluateIsValid" initialvalue="" style="color:Red;visibility:hidden;"><img src="oops.gif" border="0" /></span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Button ID="signUpButton" runat="server" Text="Sign up!" OnClick="signUpButton_Click" />
        </p>
        <asp:ValidationSummary ID="signUpSummary" runat="server" ShowMessageBox="True" />
    </form>

    <script lang="javascript">
        function RequiredCheckBoxValidatorEvaluateIsValid(val) {
            var control;
            control = document.all[val.controltovalidate];
            if (control.checked)
                return true;
            else
                return false;
        }
        // Add our span to the list of validators
        Page_Validators.push(document.all["_understandValidator"]);

        // Change the attributes of the span to be the correct types
        // This mimics code from ValidatorOnLoad() found in WebUIValidation.js
        //
        val = document.all["_understandValidator"];
        if (typeof (val.evaluationfunction) == "string") {
            eval("val.evaluationfunction = " + val.evaluationfunction + ";");
        }
        if (typeof (val.isvalid) == "string") {
            if (val.isvalid == "False") {
                val.isvalid = false;
                Page_IsValid = false;
            }
            else {
                val.isvalid = true;
            }
        } else {
            val.isvalid = true;
        }
        if (typeof (val.enabled) == "string") {
            val.enabled = (val.enabled != "False");
        }
        ValidatorHookupControlID(val.controltovalidate, val);
        ValidatorHookupControlID(val.controlhookup, val);

    </script>
</body>
</html>

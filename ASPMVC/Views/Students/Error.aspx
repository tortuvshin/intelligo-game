<%@ Page Language="C#"

    CodeBehind="~/Views/Shared/Error.aspx.cs"

    MasterPageFile="~/Views/Shared/Site.Master" 

    Inherits="ASPNetMVCTutorial.Views.Shared.Error" %>

 

<asp:Content ID="ErrorContent" ContentPlaceHolderID="ApplicationContent" runat="server">

<div style="margin-top: 10px; text-align: center">

    <table cellpadding="4px" cellspacing="4px" style="margin-left:auto; 

            margin-right:auto;">

        <tr><td class="ErrorText"><asp:Literal ID="litErrorMessage" 

                        runat="server" /></td></tr>

        <tr><td style="text-align: right">

            <asp:HyperLink ID="linkBackToMainPage" Text="Go back to main page" 

                        runat="server" />

        </td></tr>

    </table>

</div>

</asp:Content>

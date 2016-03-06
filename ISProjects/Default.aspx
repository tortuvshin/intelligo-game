<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ISProjects.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table border="0" width="100%" bgcolor="#000000" style="FONT: menu">
        <tr>
          <td>
            <asp:HyperLink runat="server" id="_mainLink" ForeColor="white" NavigateUrl="client.aspx">Main</asp:HyperLink>
            <span>&nbsp;&nbsp;|&nbsp;&nbsp;</span>
            <asp:HyperLink runat="server" id="_page2Link" ForeColor="white" NavigateUrl="page2.aspx">Page 2</asp:HyperLink>
            <span>&nbsp;&nbsp;|&nbsp;&nbsp;</span>
            <asp:HyperLink runat="server" id="_page3Link" ForeColor="white" NavigateUrl="page3.aspx">Page 3</asp:HyperLink>
            <span>&nbsp;&nbsp;|&nbsp;&nbsp;</span>
            <asp:HyperLink runat="server" id="_page4Link" ForeColor="white" NavigateUrl="page4.aspx">Page 4</asp:HyperLink>
          </td>
        </tr>
      </table>
    <div>
    
        <div>
            <asp:Button ID="signUpButton" runat="server" OnClick="signUpButton_Click" Text="Sign up" />
        </div>
    
    </div>
    </form>
</body>
</html>

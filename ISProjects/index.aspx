<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ISProjects.index" %>
<%@ OutputCache Duration="10" VaryByParam="none" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Лаборатори ажил-5</title>
    <link href="stylesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="header">
            <h1>Лаборатори ажил-5</h1>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="Large">Хуудас кээшлэлт</asp:Label>

            <asp:Label ID="Label2" runat="server">Label</asp:Label>
               
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Tahoma" Width="440px">10 секундын хугацаатай хуудсыг кээшлэнэ.</asp:Label>
        </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<System.Web.Mvc.HandleErrorInfo>" %>

<asp:Content ID="errorTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Алдаа - Цахим номын сан
</asp:Content>

<asp:Content ID="errorContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1 class="error">Алдаа.</h1>
        <h2 class="error">Алдаа гарлаа.</h2>
    </hgroup>
</asp:Content>

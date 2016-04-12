<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Lib.Models.LocalPasswordModel>" %>

<asp:Content ID="manageTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Хэрэглэгчийн мэдээлэл засах
</asp:Content>

<asp:Content ID="manageContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Хэрэглэгчийн мэдээлэл засах.</h1>
    </hgroup>

    <p class="message-success"><%: (string)ViewBag.StatusMessage %></p>

    <p>Нэвтэрсэн хэрэглэгч <strong><%: User.Identity.Name %></strong>.</p>

    <% if (ViewBag.HasLocalPassword) {
        Html.RenderPartial("_ChangePasswordPartial");
    } else {
        Html.RenderPartial("_SetPasswordPartial");
    } %>

    <section id="externalLogins">
        <%: Html.Action("RemoveExternalLogins") %>

        <h3>Add an external login</h3>
        <%: Html.Action("ExternalLoginsList", new { ReturnUrl = ViewBag.ReturnUrl }) %>
    </section>
</asp:Content>

<asp:Content ID="scriptsContent" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
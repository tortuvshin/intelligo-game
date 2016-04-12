<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ICollection<Microsoft.Web.WebPages.OAuth.AuthenticationClientData>>" %>

<% if (Model.Count == 0) { %>
    <div class="message-info">
        <p>Фэйсбүүк ашиглаж нэвтрэх <a href="http://go.microsoft.com/fwlink/?LinkId=252166">эндээс харна уу</a>
        </p>
    </div>
<% } else {
    using (Html.BeginForm("ExternalLogin", "Account", new { ReturnUrl = ViewBag.ReturnUrl })) { %>
    <%: Html.AntiForgeryToken() %>
    <fieldset id="socialLoginList">
        <legend>Log in using another service</legend>
        <p>
        <% foreach (Microsoft.Web.WebPages.OAuth.AuthenticationClientData p in Model) { %>
            <button type="submit" name="provider" value="<%: p.AuthenticationClient.ProviderName %>" title="Log in using your <%: p.DisplayName %> account"><%: p.DisplayName%></button>
        <% } %>
        </p>
    </fieldset>
    <% }
} %>

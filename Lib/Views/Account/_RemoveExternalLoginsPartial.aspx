﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ICollection<Lib.Models.ExternalLogin>>" %>

<% if (Model.Count > 0) { %>
    <h3>Бүртгэсэн хэрэглэгчийн мэдээлэл</h3>
    <table>
        <tbody>
        <% foreach (Lib.Models.ExternalLogin externalLogin in Model) { %>
            <tr>
                <td><%: externalLogin.ProviderDisplayName %></td>
                <td>
                    <% if (ViewBag.ShowRemoveButton) {
                        using (Html.BeginForm("Disassociate", "Account")) { %>
                            <%: Html.AntiForgeryToken() %>
                            <div>
                                <%: Html.Hidden("provider", externalLogin.Provider) %>
                                <%: Html.Hidden("providerUserId", externalLogin.ProviderUserId) %>
                                <input type="submit" value="Устгах" title=" <%: externalLogin.ProviderDisplayName %> " />
                            </div>
                        <% }
                    } else { %>
                        &nbsp;
                    <% } %>
                </td>
            </tr>
        <% } %>
        </tbody>
    </table>
<% } %>
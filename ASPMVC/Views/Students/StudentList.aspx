<%@ Page Language="C#"

    MasterPageFile="~/Views/Shared/Site.Master"

    CodeBehind="~/Views/Students/StudentList.aspx.cs"

    Inherits="ASPNetMVCTutorial.Views.Students.StudentList" %>

 

<asp:Content id="IndexContent" ContentPlaceHolderID="ApplicationContent" runat="server">

    <div style="float: right; margin-right: 10px">

        <asp:HyperLink id="linkAddStudent" runat="server" 

                        Text="Click to add a student to the list" />

    </div>

    <br />

    <div style="margin-top: 5px">

        <asp:Literal id="litStudentDetail" runat="server" />

    </div>

</asp:Content>

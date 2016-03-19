<%@ Page Language="C#"

    MasterPageFile="~/Views/Shared/Site.Master"

    CodeBehind="~/Views/Students/AddStudent.aspx.cs"

    Inherits="ASPNetMVCTutorial.Views.Students.AddStudent" %>

 

<asp:Content ID="AddStudentContent" 

    ContentPlaceHolderID="ApplicationContent" runat="server">

<script language="javascript" type="text/javascript">

    function SubmitForm() {

        frmAddStudent.action = hidAddstudentActionURL.value;

        frmAddStudent.submit();

    }

</script>

 

<asp:Literal ID="litAddStudentActionHidden" runat="server" />

<form id="frmAddStudent" method="post" action="">

<div style="text-align: center">

    <table cellspacing="5px" cellpadding="0px" style="text-align: 

        center; margin-left:auto; margin-right:auto;">

        <tr>

            <td class="BoldText" style="text-align: left">

                Please provide the following information to add the student:

            </td>

        </tr>

        <tr><td style="height: 10px"></td></tr>

        <tr>

            <td>

                Name&nbsp;<input type="text" id="textName" name="textName" />

                &nbsp;&nbsp;

                Score&nbsp;<input type="text" id="txtScore" name="txtScore" />

            </td>

        </tr>

        

        <tr>

            <td>

                <asp:HyperLink ID="linkCancelAddStudent" 

                    Text="Cancel add student and 

                                    return to the main page" runat="server" />

                <input type="button" value="Add student" onclick="return SubmitForm()" />

            </td>

        </tr>

    </table>

</div>

</form>

</asp:Content>


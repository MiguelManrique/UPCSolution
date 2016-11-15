<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Allvalidate() {
            var ValidationSummary = "";
            ValidationSummary += CareerValidation();
            ValidationSummary += NameValidation();
            ValidationSummary += AreaValidation();
            ValidationSummary += CreditValidation();
            if (ValidationSummary != "") {
                alert(ValidationSummary);
                return false;
            }
            else {
                alert("Information submited successfuly");
                return true;
            }
        }

        function CareerValidation() {
            var userid;
            var controlId = document.getElementById("<%=ddlCareers.ID %>");
            userid = controlId.value;
            var val;
            val = /^[0-9]+$/;
            var digits = /\d(10)/;
            if (userid == "") {
                return ("Please Enter Career" + "\n");
            }
            else if (val.test(userid)) {
                return "";
            }
        }

        function CreditValidation() {
            var userid;
            var controlId = document.getElementById("<%=txtCredit.ID %>");
        userid = controlId.value;
        var val;
        val = /^[0-9]+$/;
        var digits = /\d(10)/;
        if (userid == "") {
            return ("Please Enter Credit" + "\n");
        }
        else if (val.test(userid)) {
            return "";
        }

        else {
            return ("Credits should be only in digits" + "\n");
        }
    }
    function AreaValidation() {
        var userid;
        var controlId = document.getElementById("<%=txtArea.ID %>");
        userid = controlId.value;
        var val = /^[a-zA-Z ]+$/
        if (userid == "") {
            return ("Please Enter an Area" + "\n");
        }
        else if (val.test(userid)) {
            return "";

        }
        else {
            return ("Area accepts only spaces and charcters" + "\n");
        }
    }
        function NameValidation() {
            var userid;
            var controlId = document.getElementById("<%=txtName.ID %>");
            userid = controlId.value;
            var val = /^[a-zA-Z ]+$/
            if (userid == "") {
                return ("Please Enter Name" + "\n");
            }
            else if (val.test(userid)) {
                return "";

            }
            else {
                return ("Name accepts only spaces and charcters" + "\n");
            }
        }
</script>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        <h1>Courses</h1>
        <table border="1">
            <tr>
                <td>
                    <asp:HiddenField runat="server" ID="hfCourseId" Value="0" />
                </td>
            </tr>
            <tr>
                <td>Career</td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlCareers" DataValueField="Id" DataTextField="Name"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Area</td>
                <td>
                    <asp:TextBox runat="server" ID="txtArea"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Credit</td>
                <td>
                    <asp:TextBox runat="server" ID="txtCredit"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnSave" Text="Save" OnClientClick= "return Allvalidate()" OnClick="btnSave_Click"/>
                    <asp:Button runat="server" ID="btnClearFields" Text="Clear" OnClick="btnClearFields_Click"/>
                </td>
            </tr>
        </table>
        <asp:DataGrid runat="server" ID="dgCourses" AutoGenerateColumns="false" OnItemCommand="dgCourses_ItemCommand">
            <Columns>
                <asp:BoundColumn DataField="Id" Visible="false"></asp:BoundColumn>
                <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>
                <asp:BoundColumn DataField="Area" HeaderText="Area"></asp:BoundColumn>
                <asp:BoundColumn DataField="Credits" HeaderText="Credits"></asp:BoundColumn>
                <asp:ButtonColumn CommandName="ShowDetails" HeaderText="ShowDetails" Text="ShowDetails"></asp:ButtonColumn>
                <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"></asp:ButtonColumn>                
            </Columns>
        </asp:DataGrid>
    </div>
    </form>
</body>
</html>

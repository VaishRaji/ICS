<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ValidatorApp.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>User Information</h2>

            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtFamilyName">Family Name:</label>
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtAddress">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtCity">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtZipCode">Zip Code:</label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtPhone">Phone:</label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <br /><br />

            <label for="txtEmail">Email Address:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
            <br /><br />

            <asp:Label ID="lblValidationMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>


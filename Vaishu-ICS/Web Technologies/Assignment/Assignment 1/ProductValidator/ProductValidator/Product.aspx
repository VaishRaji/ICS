<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ProductValidator.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select a Product</h2>
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
            </asp:DropDownList>
            <br /><br />

            <asp:Image ID="imgProduct" runat="server" Height="200px" Width="200px" />
            <br /><br />

            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            <br /><br />

            <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
            <br /><br />

            <h2>Enter Your Information</h2>

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

            <asp:Button ID="btnValidate" runat="server" Text="Validate" OnClick="btnValidate_Click" />
            <br /><br />

            <asp:Label ID="lblValidationMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
        

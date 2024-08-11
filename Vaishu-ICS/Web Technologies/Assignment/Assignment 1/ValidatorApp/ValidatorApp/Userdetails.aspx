<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Userdetails.aspx.cs" Inherits="ValidatorApp.Userdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Submitted User Information</h2>
            <p><strong>Name:</strong> <asp:Label ID="lblName" runat="server"></asp:Label></p>
            <p><strong>Family Name:</strong> <asp:Label ID="lblFamilyName" runat="server"></asp:Label></p>
            <p><strong>Address:</strong> <asp:Label ID="lblAddress" runat="server"></asp:Label></p>
            <p><strong>City:</strong> <asp:Label ID="lblCity" runat="server"></asp:Label></p>
            <p><strong>Zip Code:</strong> <asp:Label ID="lblZipCode" runat="server"></asp:Label></p>
            <p><strong>Phone:</strong> <asp:Label ID="lblPhone" runat="server"></asp:Label></p>
            <p><strong>Email:</strong> <asp:Label ID="lblEmail" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>

      

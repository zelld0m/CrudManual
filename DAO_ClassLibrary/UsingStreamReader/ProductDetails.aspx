<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="UsingStreamReader.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lbl_Store" runat="server" Text="Store"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Name" runat="server" Text="Name"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Description" runat="server" Text="Description"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Price" runat="server" Text="Price"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Manufacturer" runat="server" Text="Manufacturer"></asp:Label>
          <br />
          <br />
     
        <asp:Image ID="Image" runat="server" />
     
        <br />
&nbsp;<br />
        <asp:Label ID="lbl_Availability" runat="server" Text="Availability:"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>

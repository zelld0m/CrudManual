<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="UsingStreamReader.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="HP Inc." />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Humanscale" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="A4 TECH" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </form>
</body>
</html>

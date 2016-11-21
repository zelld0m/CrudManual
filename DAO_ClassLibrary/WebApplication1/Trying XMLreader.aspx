<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trying XMLreader.aspx.cs" Inherits="WebApplication1.Trying_XMLreader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
        </asp:TreeView>
    
    </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/DataFiles/Brand_XML.xml" XPath="/response/*"></asp:XmlDataSource>
    </form>
</body>
</html>

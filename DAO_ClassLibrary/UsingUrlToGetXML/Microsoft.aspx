<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Microsoft.aspx.cs" Inherits="UsingUrlToGetXML.Microsoft" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 544px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <br />      
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Lbl_Find" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Btn_Find" runat="server" Text="Find" OnClick="Btn_Find_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Lbl_Data1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Btn_Fill1" runat="server" Text="Fill1" OnClick="Btn_Fill1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
    
        <asp:Label ID="Lbl_Data2" runat="server" Text="Label"></asp:Label>

                </td>
                <td>
                    <asp:Button ID="Btn_Fill2" runat="server" Text="fill2" OnClick="Btn_Fill2_Click" />
                </td>
            </tr>
        </table>
        <br />
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
    
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

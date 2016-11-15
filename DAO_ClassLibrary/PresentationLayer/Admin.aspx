<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="PresentationLayer.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 201px;
        }
        .auto-style3 {
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>ID:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>AccessLevel:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td colspan="2">
                    <asp:GridView ID="GridView2" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Btn_refresh" runat="server" OnClick="Btn_AuthorityName_Click" Text="Refresh" Width="28px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="_Tb_ID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="_Tb_Name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="_Tb_AuthorityName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="_Tb_AccessLevel" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style3">Name</td>
                <td>AuthorityName</td>
                <td>AccessLevel</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="_BtnAdd" runat="server" OnClick="_BtnAdd_Click" style="height: 26px" Text="add" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="_BtnSearch" runat="server" OnClick="_BtnSearch_Click" Text="Search" />
                </td>
                <td>
                    <asp:Button ID="_BtnUpdate" runat="server" OnClick="_BtnUpdate_Click" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="_btnDelete" runat="server" OnClick="_btnDelete_Click" Text="Delete" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

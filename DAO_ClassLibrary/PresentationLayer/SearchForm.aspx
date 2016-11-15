<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForm.aspx.cs" Inherits="PresentationLayer.SearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 215px;
        }
        .auto-style6 {
            width: 136px;
        }
        .auto-style7 {
            width: 215px;
            height: 137px;
        }
        .auto-style8 {
            width: 136px;
            height: 137px;
        }
        .auto-style9 {
            height: 137px;
        }
        .auto-style10 {
            height: 25px;
        }
        .auto-style11 {
            width: 538px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>
                    <asp:Button ID="Btn_Back" runat="server" OnClick="Btn_Back_Click" style="width: 46px" Text="Back" />
                </td>
                <td>
                    <asp:Button ID="Btn_Logout" runat="server" OnClick="Btn_Logout_Click" Text="Logout" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Search By AccessLevel</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:RadioButton ID="rb_1" runat="server" OnCheckedChanged="rb_1_CheckedChanged" Text="Dell" AutoPostBack="True" GroupName="Brand" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="rb_2" runat="server" Text="Acer" AutoPostBack="True" GroupName="Brand" OnCheckedChanged="rb_2_CheckedChanged" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <asp:RadioButton ID="rb_3" runat="server" Text="Asus" AutoPostBack="True" GroupName="Brand" OnCheckedChanged="rb_3_CheckedChanged" />
                            </td>
                            <td class="auto-style10"></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="rb_4" runat="server" Text="HP" AutoPostBack="True" GroupName="Brand" OnCheckedChanged="rb_4_CheckedChanged" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="rb_5" runat="server" Text="Apple" AutoPostBack="True" GroupName="Brand" OnCheckedChanged="rb_5_CheckedChanged" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <asp:RadioButton ID="rb_ALL" runat="server" Text="ALL" AutoPostBack="True" GroupName="Brand" OnCheckedChanged="rb_ALL_CheckedChanged" />
                </td>
                <td class="auto-style8"></td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style9">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

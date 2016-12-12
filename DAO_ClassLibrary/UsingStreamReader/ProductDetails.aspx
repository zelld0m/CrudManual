<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="UsingStreamReader.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Bootstrap/css/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="Bootstrap/js/bootstrap.js" type="text/javascript"></script>
    <script src="Bootstrap/js/jquery.js" type="text/javascript"></script>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 53%;
            left: 32px;
            top: -72px;
            padding-left: 15px;
            padding-right: 15px;
        }

        .auto-style2 {
            min-height: 20px;
            padding: 19px;
            margin-bottom: 20px;
            background-color: #f5f5f5;
            border: 1px solid #e3e3e3;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .05);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, .05);
            margin-left: 0px;
            width: 453px;
            height: 147px;
        }

        .auto-style3 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 57%;
            left: -1px;
            top: -6px;
            height: 131px;
            padding-left: 15px;
            padding-right: 15px;
        }


        .auto-style4 {
            min-height: 20px;
            padding: 19px;
            margin-bottom: 20px;
            background-color: #f5f5f5;
            border: 1px solid #e3e3e3;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .05);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, .05);
            width: 642px;
        }

        .auto-style5 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 780px;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="panel panel-info">
                        <div class="panel-body">
                            <div class="form-inline text-center">
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                    <asp:ListItem Selected="True">5</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>25</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                    <asp:ListItem>75</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>150</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Button ID="BtnALL" runat="server" OnClick="BtnALL_Click" Text="All" CssClass="btn btn-success" />
                                <asp:TextBox ID="TB_Search" runat="server" OnTextChanged="TB_Search_TextChanged" CssClass="form-control"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Search" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class=" col-sm-4">
                    <div class="panel panel-danger">
                        <div class="panel-body">
                            <asp:RadioButtonList ID="rdbtnlst_Brand" runat="server" OnSelectedIndexChanged="rdbtnlst_Brand_SelectedIndexChanged" AutoPostBack="True" Style="left: 0px; top: 0px"></asp:RadioButtonList>
                        </div>
                    </div>
                </div>
                <div class=" col-sm-8">
                    <asp:Panel ID="Panel1" runat="server" CssClass="panel panel-success">
                        <div class="panel-body">
                            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

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
            width: 33.33333333%;
            left: 2px;
            top: -91px;
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
            margin-left: 40px;
            width: 288px;
            height: 67px;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 40%;
            left: 1px;
            top: 4px;
            height: 131px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="row">
            <div class="col-sm-12">
                <div class="col-sm-4">
                    <div class="well">
                        <asp:RadioButtonList ID="rdbtnlst_Brand" runat="server" CssClass=" checkbox" OnSelectedIndexChanged="rdbtnlst_Brand_SelectedIndexChanged" AutoPostBack="True" style="left: 0px; top: 0px" ></asp:RadioButtonList>
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                    </div>
                </div>
                <div class="auto-style3">
                    <div class="auto-style2">
                        <asp:Button ID="BtnALL" runat="server" OnClick="BtnALL_Click" Text="ALL" Height="30px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOAD EDP" Height="30px" />
                        <br />
                        <br />
                        <br />
                    </div>
                </div>
                <div class="auto-style1">
                    <br />
                    <br />
                    
                    <br />
                    <asp:Panel ID="Panel1" runat="server" BackColor="WhiteSmoke"  BorderColor="WindowFrame">
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                    </asp:Panel>
                </div>
            </div>
        </div>
        <!--  TEST -->



        <!-- END TEST -->

    </form>
</body>
</html>

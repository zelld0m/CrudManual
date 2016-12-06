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
            left: 0px;
            top: -91px;
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
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="well">
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                        <asp:Button ID="btnCreate" runat="server" Text="Anthro Corp" OnClick="btnCreate_Click" />
                        <asp:Button ID="Btn_Lenovo" runat="server" OnClick="Button1_Click" Text="Lenovo" />
                        <asp:Button ID="BtnALL" runat="server" OnClick="BtnALL_Click" Text="ALL" />
                        <asp:Button ID="Btn_Quatech" runat="server" OnClick="Btn_Quatech_Click" Text="Quatech" />
                    </div>
                </div>
                <div class="auto-style1">
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                    </asp:Panel>
                </div>
            </div>
        </div>
        <!--  TEST -->



        <!-- END TEST -->

    </form>
</body>
</html>

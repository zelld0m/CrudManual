<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="UsingStreamReader.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Bootstrap/css/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="Bootstrap/js/bootstrap.js" type="text/javascript"></script>
    <script src="Bootstrap/js/jquery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="row">
            <div class="col-sm-12">
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4">
                    <div class="well">
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" CssClass="btn btn-info" />
                    </div>
                </div>
                <div class="col-sm-4">
                </div>
            </div>
        </div>
        <!--  TEST -->



        <!-- END TEST -->

    </form>
</body>
</html>

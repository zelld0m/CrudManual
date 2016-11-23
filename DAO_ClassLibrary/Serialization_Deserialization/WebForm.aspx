<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Serialization_Deserialization.WebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    PRODUCT INFORMATION<br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    ID:<asp:TextBox ID="TB_ID" runat="server"></asp:TextBox>
    <br />
    NAME:<asp:TextBox ID="TB_Name" runat="server"></asp:TextBox>
    <br />
    PRICE:<asp:TextBox ID="TB_Price" runat="server"></asp:TextBox>
    <br />
    UNIT:<asp:TextBox ID="TB_Unit" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

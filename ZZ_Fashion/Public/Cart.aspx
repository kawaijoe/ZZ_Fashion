<%@ Page Title="" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ZZ_Fashion.Public.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Cart
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <img src="Image/cart.PNG" width="100%" />
    <br />
    <br />
    <div style="display: block; float: right;">
        <asp:Button ID="Checkout" runat="server" Text="Checkout" />
    </div>

</asp:Content>

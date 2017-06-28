<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Login:
        <asp:TextBox ID="txtLoginID" runat="server" ></asp:TextBox>
    </p>
    <p>
        Password :
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="height: 26px" Text="Login" />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </p>
</asp:Content>

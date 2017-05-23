<%@ Page Title="" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZZ_Fashion.Public.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Email:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Password:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="padding-top: 5px">
        <div class="col-md-6">
        </div>
        <div class="col-md-6">
            <asp:Button ID="Signin" runat="server" Text="Login" align="right" />
        </div>
    </div>
    <br />
    <div style="text-align: center;">
        <a href="" style="align-items: center;">Don't have an account?</a>
        <br />
        <a href="" style="align-items: center;">Forgot Password?</a>
    </div>

    
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ZZ_Fashion.Public.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
        <div class="col-md-6"></div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>UserID:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a UserID!" Display="Dynamic" ControlToValidate="UserID"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Password:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter a Password!" Display="Dynamic" ControlToValidate="Password"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>User Type:</b>
        </div>
        <div class="col-md-6">
            <asp:RadioButton ID="RadioButtonCustomer" runat="server" Text="Customer" GroupName="type" />
            <asp:RadioButton ID="RadioButtonStaff" runat="server" Text="Staff" GroupName="type"/>
        </div>
    </div>

    <div class="row" style="padding-top: 5px" validationgroup="SelectLogin" id="LoginType">
        <div class="col-md-6">
        </div>
        <div class="col-md-6">
            <asp:Button ID="Signin" runat="server" Text="Login" align="right" OnClick="Signin_Click" />
        </div>
    </div>
    <br />

    
</asp:Content>

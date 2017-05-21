<%@ Page Title="" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ZZ_Fashion.Public.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Register
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Name:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Gender:</b>
        </div>
        <div class="col-md-6">
            <asp:RadioButton ID="Male" runat="server" GroupName="Gender" Text="Male" />
            <br />
            <asp:RadioButton ID="Female" runat="server" GroupName="Gender" Text="Female" />
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Birth Date:</b>
        </div>
        <div class="col-md-6">
            <asp:Calendar ID="BirthDay" runat="server"></asp:Calendar>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Address:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Country:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Country" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Telephone Number:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="TelephoneNumber" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Email Address:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            <b>Password:</b>
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
        </div>
        <div class="col-md-6">
            <asp:Button ID="Submit" runat="server" Text="Register" />
        </div>
    </div>
</asp:Content>

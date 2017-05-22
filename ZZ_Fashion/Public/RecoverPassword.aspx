<%@ Page Title="" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="ZZ_Fashion.Public.RecoverPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Recover Password
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            Email:
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            New Password:
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
            Confirm New Password:
        </div>
        <div class="col-md-6">
            <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="padding-top: 5px">
        <div class="col-md-6" align="right">
        </div>
        <div class="col-md-6">
            <asp:Button ID="Submit" runat="server" Text="Submit" />
        </div>
    </div>

</asp:Content>

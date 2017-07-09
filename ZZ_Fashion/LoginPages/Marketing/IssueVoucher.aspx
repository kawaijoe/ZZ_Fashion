<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="IssueVoucher.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.IssueVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="Title" runat="server" Text="Issue voucher"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Description" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Confirm" runat="server" Text="Confirm" OnClick="OnConfirm"/>
                <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="OnCancel"/>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

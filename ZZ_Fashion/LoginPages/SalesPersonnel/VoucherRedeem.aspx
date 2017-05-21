<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VoucherRedeem.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.VoucherRedeem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Navbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarRight" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>REDEEM CASH VOUCHER</td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 116px">Serial Number:</td>
            <td>
                <asp:TextBox ID="SerialNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>
                <asp:Button ID="Redeem" runat="server" Text="REDEEM" />
            </td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

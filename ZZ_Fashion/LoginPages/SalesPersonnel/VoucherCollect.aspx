<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VoucherCollect.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.VoucherCollect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Navbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarRight" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>VOURCHER COLLECT</td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 99px">Serial Number:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>
                <asp:Button ID="Update" runat="server" Text="UPDATE" />
            </td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

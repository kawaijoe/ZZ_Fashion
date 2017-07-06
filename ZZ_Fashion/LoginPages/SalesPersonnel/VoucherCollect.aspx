<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/SalesPersonnel/SalesPersonnel.master" AutoEventWireup="true" CodeBehind="VoucherCollect.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.VoucherCollect" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>VOURCHER COLLECT</td>
        </tr>
        <tr>
            <td style="width: 99px; height: 22px;"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 99px">Serial Number:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server">M000000</asp:TextBox>
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

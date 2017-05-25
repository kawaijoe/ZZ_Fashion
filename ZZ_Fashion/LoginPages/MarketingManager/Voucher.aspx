<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/MarketingManager/MarketingManager.master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="ZZ_Fashion.LoginPages.MarketingManager.Voucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table style="width: 100%;">
        <tr>
            <td style="width: 141px">
                <asp:Label ID="Label1" runat="server" Text="Customer ID:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">
                <asp:Label ID="Label2" runat="server" Text="Customer Name:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Bobby McBobbinson"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">
                <asp:Label ID="Label4" runat="server" Text="Amount spent:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="$10000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">
                <asp:Label ID="Label6" runat="server" Text="Eligible Voucher:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="$160.00"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">
                <asp:Button ID="Button1" runat="server" Text="Issue Voucher" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

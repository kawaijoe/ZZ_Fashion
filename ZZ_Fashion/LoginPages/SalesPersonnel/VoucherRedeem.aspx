<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/SalesPersonnel/SalesPersonnel.master" AutoEventWireup="true" CodeBehind="VoucherRedeem.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.VoucherRedeem" %>

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
                <asp:TextBox ID="txtSerialNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td id="cvError">
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Invalid Serial Number!" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>
                <asp:Button ID="btnRedeem" runat="server" Text="REDEEM" OnClick="Redeem_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 116px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

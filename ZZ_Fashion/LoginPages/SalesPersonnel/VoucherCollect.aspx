<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/SalesPersonnel/SalesPersonnel.master" AutoEventWireup="true" CodeBehind="VoucherCollect.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.VoucherCollect" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>VOURCHER COLLECT</td>
        </tr>
        <tr>
            <td style="width: 99px; height: 22px;"></td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 99px; height: 24px;">MemberID:</td>
            <td style="height: 24px">
                <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 99px; height: 22px;"></td>
            <td style="height: 22px">
                <asp:CustomValidator ID="cvError" runat="server" ControlToValidate="txtSerialNo" ErrorMessage="Member Invalid!" OnServerValidate="cvError_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 99px; height: 22px;"></td>
            <td style="height: 22px">
            </td>
        </tr>
        <tr>
            <td style="width: 99px; height: 22px;">Serial No:</td>
            <td style="height: 22px">
                <asp:TextBox ID="txtSerialNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>
                <asp:Label ID="lblUpdated" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 99px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

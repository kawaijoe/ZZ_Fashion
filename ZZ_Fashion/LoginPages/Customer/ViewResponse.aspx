<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="ViewResponse.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.ViewResponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellpadding="0" cellspacing="0" class="nav-justified">
        <tr>
            <td style="width: 282px; height: 81px; font-size: x-large;" colspan="2"><strong>Feedback</strong></td>
        </tr>
        <tr>
            <td style="width: 133px">Title of&nbsp; FeedBack:</td>
            <td>
                <asp:Label ID="Title" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 19px; width: 133px;">
                message:</td>
            <td style="height: 19px">
                <asp:Label ID="FeedbackMsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Responces:</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Response" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="AddFeedBack" runat="server" Text="Add Feedback" />
            </td>
        </tr>
    </table>
</asp:Content>

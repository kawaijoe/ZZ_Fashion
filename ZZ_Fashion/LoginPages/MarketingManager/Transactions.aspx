<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/MarketingManager/MarketingManager.master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="ZZ_Fashion.LoginPages.MarketingManager.ViewList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <br />
                <asp:Label ID="TransactionsTitle" runat="server" Text="Transactions for the month of April"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <img src="images/Fake2.PNG" />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

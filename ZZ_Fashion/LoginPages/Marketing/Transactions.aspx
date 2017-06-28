<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.Transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="title" runat="server" Text=""></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="monthlyTransactions" runat="server" AllowPaging="True" OnRowDataBound="OnBound"></asp:GridView>
                <asp:Button ID="submit" runat="server" Style="display: none;" OnClick="OnClick" OnClientClick="UpdateControl();" PostBackUrl="./IssueVoucher.aspx" />
            </td>
        </tr>
    </table>
</asp:Content>

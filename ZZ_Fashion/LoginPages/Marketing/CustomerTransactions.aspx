<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="CustomerTransactions.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.CustomerTransactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="Title" runat="server" Text="Top monthly transactions"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="Transactions" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="MemberID" HeaderText="Customer ID" />
                        <asp:BoundField DataField="Spending" HeaderText="Spending" />
                        <asp:HyperLinkField DataNavigateUrlFields="MemberID,Spending" DataNavigateUrlFormatString="./IssueVoucher.aspx?id={0}spending={1}" Text="Issue voucher" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

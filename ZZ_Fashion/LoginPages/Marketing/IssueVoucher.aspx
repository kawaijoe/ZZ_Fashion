﻿<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="IssueVoucher.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.IssueVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="title" runat="server" Text=""></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="amount" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="issue" runat="server" Text="Issue cash vouchers" OnClick="OnClick"/>
            </td>
        </tr>
    </table>
</asp:Content>

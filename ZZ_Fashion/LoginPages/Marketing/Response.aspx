<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.Response" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Respond to customer feedback
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="customerInformation" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="feedback" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="feedbackResponse" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="submit" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>

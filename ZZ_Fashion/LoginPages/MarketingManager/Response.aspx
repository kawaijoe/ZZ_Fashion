<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/MarketingManager/MarketingManager.master" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="ZZ_Fashion.LoginPages.MarketingManager.Response" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <br />
                <asp:Label ID="FeedbackResponseTitle" runat="server" Text="Feedback Response"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="FeedbackTitle" runat="server" Text="Customer ID"></asp:Label>
                <asp:DropDownList ID="CustomerID" runat="server"></asp:DropDownList>
                <br />
                <asp:TextBox ID="Feedback" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:Label ID="ResponseTitle" runat="server" Text="Response"></asp:Label>
                <br />
                <asp:TextBox ID="FeedbackResponse" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/MarketingManager/MarketingManager.master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="ZZ_Fashion.LoginPages.MarketingManager.ViewFeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <br />
                <asp:Label ID="FeedbackTitle" runat="server" Text="Customer Feedback"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <img src ="images/Fake.PNG" />
                <asp:GridView ID="Feedback" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

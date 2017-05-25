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
                <br />
                <asp:Label ID="FeedbackTitle" runat="server" Text="Feedback ID: "></asp:Label>
                <asp:DropDownList ID="CustomerID" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text ="Customer ID: 0001"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Feedback: "></asp:Label>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:Label ID="ResponseTitle" runat="server" Text="Response:"></asp:Label>
                <br />
                <asp:TextBox ID="FeedbackResponse" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>

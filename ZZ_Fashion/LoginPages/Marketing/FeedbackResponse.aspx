<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="FeedbackResponse.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.FeedbackResponse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="Title" runat="server" Text="Respond to feedback"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="FeedbackTitle" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Information" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Feedback" runat="server" Text=""></asp:Label>
            </td>

            <td>
                <asp:Image ID="Attached" runat="server" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:TextBox ID="NewResponse" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Confirm" runat="server" Text="Confirm" OnClick="OnConfirm"/>
                <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="OnCancel"/>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

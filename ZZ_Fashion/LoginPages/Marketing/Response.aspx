<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.Response" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="title" runat="server" Text=""></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="meta" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="feedback" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="oldResponse" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="newResponse" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="responseRequiredValidator" runat="server" ErrorMessage="Response cannot be blank" Display="Dynamic" ControlToValidate="response"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick ="OnSubmit"/>
            </td>
        </tr>
    </table>
</asp:Content>

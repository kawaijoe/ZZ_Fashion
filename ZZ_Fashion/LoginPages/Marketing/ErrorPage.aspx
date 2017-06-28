<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Whoops, something went wrong! 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Bring me back to the feedback page" OnClick="OnRedirect"/>
</asp:Content>

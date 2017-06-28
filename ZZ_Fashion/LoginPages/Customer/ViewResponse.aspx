<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="ViewResponse.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.ViewResponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvFeedback" CssClass="col-xs-12 col-xs-push-4" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvFeedback_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title:" ReadOnly="True" />
            <asp:BoundField DataField="Feedback Text" HeaderText="Messages:" ReadOnly="True" />
        </Columns>
    </asp:GridView>
    <br />

    <asp:GridView ID="gvResponse" CssClass="col-xs-12 col-xs-push-4" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvFeedback_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Text" HeaderText="Response:" ReadOnly="True" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="CreateFeedback" runat="server" Text="Create Feedback" />
</asp:Content>

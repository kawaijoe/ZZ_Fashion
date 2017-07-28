<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="ViewResponse.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.ViewResponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvFeedback" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="col-xs-12 col-xs-push-4" DataKeyNames="FeedbackID" OnSelectedIndexChanged="gvFeedback_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title:" ReadOnly="True" />
            <asp:BoundField DataField="Text" HeaderText="Messages:" ReadOnly="True" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="lblStaffMessage" runat="server"></asp:Label>
    <br />

    <asp:GridView ID="gvStaffResponse" runat="server" AutoGenerateColumns="False" CssClass="col-xs-12 col-xs-push-4" style="left: 0px; top: 0px; width: 97%">
        <Columns>
            <asp:BoundField DataField="DateTimePosted" HeaderText="DateTimePosted" />
            <asp:BoundField DataField="Text" HeaderText="Response by Staff" ReadOnly="True" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="lblCustomerMessage" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="gvCustomerResponse" runat="server" AutoGenerateColumns="False" CssClass="col-xs-12 col-xs-push-4" style="left: 0px; top: 0px; width: 97%">
        <Columns>
            <asp:BoundField DataField="DateTimePosted" HeaderText="DateTimePosted" />
            <asp:BoundField DataField="Text" HeaderText="Response by Customer" ReadOnly="True" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="CreateFeedback" runat="server" Text="Create Feedback" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="CreateResponse" runat="server" OnClick="CreateResponse_Click" Text="Create Response" />
</asp:Content>

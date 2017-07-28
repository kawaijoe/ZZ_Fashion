<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Marketing/Marketing.master" AutoEventWireup="true" CodeBehind="CustomerFeedback.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Marketing.CustomerFeedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    <asp:Label ID="Title" runat="server" Text="Customers' feedback"></asp:Label>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:GridView ID="Feedback" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="FeedbackID" HeaderText="Feedback ID" />
                        <asp:BoundField DataField="MemberID" HeaderText="Customer ID" />
                        <asp:BoundField DataField="DateTimePosted" HeaderText="Date Posted" />
                        <asp:BoundField DataField="Title" HeaderText="Title" />
                        <asp:BoundField DataField="Text" HeaderText="Feedback" NullDisplayText="No feedback" />
                        <asp:ImageField DataImageUrlField="ImageFileName" DataImageUrlFormatString="~/Images/{0}" HeaderText="Image Attached" NullDisplayText="No image attached">
                        </asp:ImageField>
                        <asp:HyperLinkField DataNavigateUrlFields="FeedbackID,MemberID,DateTimePosted,Title,Text,ImageFileName" DataNavigateUrlFormatString="./Response.aspx?id={0}&amp;customer={1}&amp;posted={2}&amp;title={3}&amp;text={4}&amp;attachment={5}" Text="Respond" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="CreateResponse.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.CreateResponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 200px; font-size: x-large"><strong>Response</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">MemberID:</td>
            <td>
                <asp:TextBox ID="ResponseMemberID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">Message:</td>
            <td>
                <asp:TextBox ID="ResponseText" runat="server" Height="124px" TextMode="MultiLine" Width="552px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 200px">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
                <asp:Label ID="Message" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

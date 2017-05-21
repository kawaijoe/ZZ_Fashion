<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/SalesPersonnel/SalesPersonnel.master" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.CreateCustomer" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 134px">&nbsp;</td>
            <td>CREATE CUSTOMER</td>
        </tr>
        <tr>
            <td style="width: 134px">Membership ID:</td>
            <td>
                <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Name:</td>
            <td>
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Gender:</td>
            <td>
                <asp:CheckBox ID="Male" runat="server" />
                <a>Male</a>                
                <asp:CheckBox ID="Female" runat="server" />
                <a>Female</a>                
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Date of birth:</td>
            <td>
                <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Email Address:</td>
            <td>
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Phone Number:</td>
            <td>
                <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 134px">Residential Address</td>
            <td style="height: 24px">
                <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="Add" runat="server" Text="ADD" />
            </td>
        </tr>
    </table>
</asp:Content>

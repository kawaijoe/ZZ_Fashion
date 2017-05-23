<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellpadding="0" cellspacing="0" class="nav-justified">
    <tr>
        <td style="width: 282px; height: 81px; font-size: x-large;"><strong>Profile</strong></td>
        <td style="height: 81px"></td>
    </tr>
    <tr>
        <td style="width: 282px; height: 38px">Name : </td>
        <td style="height: 38px">
            <asp:Label ID="Name" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 42px">Gender: </td>
        <td style="height: 42px">
            <asp:Label ID="Gender" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 34px">BirthDate:</td>
        <td style="height: 34px">
            <asp:Label ID="BirthDate" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 60px">Email Address:</td>
        <td style="height: 60px">
            <asp:Label ID="EmailAddr" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 51px;">Phone Number:</td>
        <td style="height: 51px">
            <asp:Label ID="PhoneNum" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 54px;">Residential Address</td>
        <td style="height: 54px">
            <asp:Label ID="ResidentialAddr" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px; height: 51px;">Country: </td>
        <td style="height: 51px">
            <asp:Label ID="Country" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 282px">&nbsp;</td>
        <td>
            <asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="Edit" Height="31px" Width="87px" />
        </td>
    </tr>
</table>
</asp:Content>

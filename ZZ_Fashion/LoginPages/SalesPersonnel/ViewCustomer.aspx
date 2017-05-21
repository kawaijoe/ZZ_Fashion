<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/SalesPersonnel/SalesPersonnel.master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="ZZ_Fashion.LoginPages.SalesPersonnel.ViewCustomers" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>VIEW CUSTOMERS</td>
        </tr>
        <tr>
            <td style="width: 131px">Search (ID / Name):</td>
            <td>
                <asp:TextBox ID="Search" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>
                <asp:ListBox ID="CustomerList" runat="server" Height="240px" Width="173px"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>

</asp:Content>

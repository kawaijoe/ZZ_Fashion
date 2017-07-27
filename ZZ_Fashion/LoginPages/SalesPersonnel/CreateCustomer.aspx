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
                <asp:TextBox ID="ID" runat="server">M00000001</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Name:</td>
            <td>
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqName" runat="server" Display="Dynamic" ErrorMessage="REQUIRED FIELD" ControlToValidate="Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Gender:</td>
            <td>
                <asp:RadioButton ID="M" runat="server" GroupName="Gender" OnCheckedChanged="M_CheckedChanged" Text="Male" />
                <asp:RadioButton ID="F" runat="server" GroupName="Gender" Text="Female" />
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Date of birth:</td>
            <td>
                <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqDOB" runat="server" Display="Dynamic" ErrorMessage="REQUIRED FIELD" ControlToValidate="DOB"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Email Address:</td>
            <td>
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="REQUIRED FIELD" ControlToValidate="Email"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">Phone Number:</td>
            <td>
                <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqPhone" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ControlToValidate="Phone">REQUIRED FIELD</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 134px">Residential Address</td>
            <td style="height: 24px">
                <asp:TextBox ID="Address" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqAddress" runat="server" Display="Dynamic" ErrorMessage="REQUIRED FIELD" ControlToValidate="Address"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 134px">Country</td>
            <td style="height: 24px">
                <asp:DropDownList ID="ddlCountry" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="Add" runat="server" Text="ADD" OnClick="Add_Click" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

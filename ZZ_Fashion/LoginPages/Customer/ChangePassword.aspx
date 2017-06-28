<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/Customer/Customer.master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ZZ_Fashion.LoginPages.Customer.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellpadding="0" cellspacing="0" class="nav-justified">
        <tr>
            <td style="width: 282px; height: 81px; font-size: x-large;"><strong>Profile</strong></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 282px; height: 65px;">Old Password:</td>
            <td style="height: 65px">
                <asp:TextBox ID="OldPass" runat="server"></asp:TextBox>
                <asp:CustomValidator ID="IncorrectPass" runat="server" ControlToValidate="OldPass" Display="Dynamic" ErrorMessage="Incorrect password" OnServerValidate="IncorrectPass_ServerValidate" ForeColor="Red"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 282px; height: 79px;">New Password:</td>
            <td style="height: 79px">
                <asp:TextBox ID="NewPass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 282px; height: 76px;">Confirm New Password</td>
            <td style="height: 76px">
                <asp:TextBox ID="ConfirmNewPass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 282px"></td>
            <td style="height: 20px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
                <asp:Label ID="Message" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 282px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

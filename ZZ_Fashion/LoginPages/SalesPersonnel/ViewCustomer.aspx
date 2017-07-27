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
                <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>
                <asp:GridView ID="cusList" runat="server" AutoGenerateColumns="False" Height="184px" Width="752px">
                    <Columns>
                        <asp:BoundField DataField="MemberID" HeaderText="ID" />
                        <asp:BoundField DataField="MName" HeaderText="Name" />
                        <asp:BoundField DataField="MGender" HeaderText="Gender" />
                        <asp:BoundField DataField="MBirthDate" HeaderText="BirthDate" />
                        <asp:BoundField DataField="MAddress" HeaderText="Residential Address" />
                        <asp:BoundField DataField="MCountry" HeaderText="Country" />
                        <asp:BoundField DataField="MTelNo" HeaderText="Tel No." />
                        <asp:BoundField DataField="MEmailAddr" HeaderText="Email Address" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 131px; height: 22px;"></td>
            <td style="height: 22px">
                <asp:Label ID="lblView" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>

</asp:Content>

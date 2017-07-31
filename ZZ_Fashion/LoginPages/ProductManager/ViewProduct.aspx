 <%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/ProductManager/ProductManager.master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="ZZ_Fashion.LoginPages.ProductManager.ViewProduct" %>

<asp:Content ID="Content" ContentPlaceHolderID="PageTitle" runat="server">
    View Product
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gv" runat="server" AllowPaging="True" OnPageIndexChanging="gv_PageIndexChanging" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ID" />
            <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Product/{0}" HeaderText="Image">
                <ControlStyle Width="300px" />
            </asp:ImageField>
            <asp:BoundField DataField="Product" HeaderText="Product" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <asp:BoundField DataField="EffectiveDate" HeaderText="Effective Date" />
            <asp:BoundField DataField="Obsolete" HeaderText="Obsolete" />
            <asp:HyperLinkField DataNavigateUrlFormatString="UpdateProduct.aspx?productid={0}" Text="Edit" DataNavigateUrlFields="ProductID" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
</asp:Content>

<%@ Page Title="Catalogue" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="Catalogue.aspx.cs" Inherits="ZZ_Fashion.Public.Catalogue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Catalogue
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-3">
            <div class="row">
                <div class="col-md-7" style="padding-top:5px">
                    <b>FILTERED BY:</b>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="padding-top:5px">
                    <asp:CheckBox ID="NewArrival" runat="server" Text="New Arrivals" OnCheckedChanged="NewArrival_CheckedChanged" AutoPostBack="true" />
                </div>
            </div>
        </div>
        <div class="col-md-9">
            <asp:GridView ID="gv" runat="server" AllowPaging="True" OnPageIndexChanging="gv_PageIndexChanging" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False">
                <Columns>
                    <asp:ImageField DataImageUrlField="ProductImage" DataImageUrlFormatString="~/Images/Product/{0}" HeaderText="Image" >
                        <ControlStyle Width="300px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Product" HeaderText="Product" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
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
        </div>
    </div>

</asp:Content>

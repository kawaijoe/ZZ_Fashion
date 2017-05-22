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
                <div class="col-md-5">
                    <asp:Button ID="ClearAll" runat="server" Text="Clear All" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="padding-top:5px">
                    Minimum Price:<br />
                    <asp:TextBox ID="MinPrice" runat="server"></asp:TextBox>
                    <br />
                    Maximum Price:<br />
                    <asp:TextBox ID="MaxPrice" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="padding-top:5px">
                    <asp:CheckBox ID="NewArrival" runat="server" Text="New Arrivals" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12" style="padding-top:5px">
                    Gender:<br />
                    <asp:CheckBox ID="Male" runat="server" Text="Male" />
                    <br />
                    <asp:CheckBox ID="Female" runat="server" Text="Female" />
                </div>
            </div>
        </div>
        <div class="col-md-9">
            <img src="~/Public/Image/catalogue.PNG" style="width: 100%" runat="server" />
            <img src="~/Public/Image/catalogue.PNG" style="width: 100%" runat="server" />
            <img src="~/Public/Image/catalogue.PNG" style="width: 100%" runat="server" />
        </div>
    </div>

</asp:Content>

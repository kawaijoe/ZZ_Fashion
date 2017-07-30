<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/ProductManager/ProductManager.master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="ZZ_Fashion.LoginPages.ProductManager.CreateProduct" %>

<asp:Content ID="Content" ContentPlaceHolderID="PageTitle" runat="server">
    Create Product
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row top-padding">
        <div class="col-md-4" align="right">Title:</div>
        <div class="col-md-8">
            <asp:TextBox ID="ProductTitle" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a product title!" ControlToValidate="ProductTitle" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right"></div>
        <div class="col-md-8">
            <asp:Image ID="ImagePreview" runat="server" ImageUrl="~/Images/Placeholder.jpg" Height="190px" Width="178px" />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Image:</div>
        <div class="col-md-8">
            <asp:FileUpload ID="UploadPhoto" runat="server" CausesValidation="False" />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Price:</div>
        <div class="col-md-8">
            <asp:TextBox ID="Price" runat="server" OnTextChanged="Price_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter a price!" Display="Dynamic" ControlToValidate="Price"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Price has to be a number more than 20!" ControlToValidate="Price" Operator="GreaterThanEqual" ValueToCompare="20" Type="Currency"></asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Price has to be a number less than 500!" ControlToValidate="Price" Operator="LessThanEqual" ValueToCompare="500" Type="Currency"></asp:CompareValidator>
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Effective Date:</div>
        <div class="col-md-8">
            <asp:Calendar ID="EffectiveDate" runat="server"></asp:Calendar>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="You cannot select a date before today!" Display="Dynamic" OnServerValidate="CalendarValidate"></asp:CustomValidator>
            <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="You cannot select a date before today!" Display="Dynamic" ClientValidationFunction="CalendarValidate"></asp:CustomValidator>
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right"></div>
        <div class="col-md-8">
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right"></div>
        <div class="col-md-8">
            <asp:Label ID="status" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

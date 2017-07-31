<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/ProductManager/ProductManager.master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="ZZ_Fashion.LoginPages.ProductManager.UpdateProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Update Products
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row top-padding">
        <div class="col-md-4" align="right">Title:</div>
        <div class="col-md-8">
            <asp:TextBox ID="ProductTitle" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a product title!" ControlToValidate="ProductTitle" Display="Dynamic"></asp:RequiredFieldValidator>
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
            <asp:TextBox ID="Price" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter a price!" Display="Dynamic" ControlToValidate="Price"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Price has to be a number more than 20!" ControlToValidate="Price" Operator="GreaterThanEqual" ValueToCompare="20" Type="Currency"></asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Price has to be a number less than 500!" ControlToValidate="Price" Operator="LessThanEqual" ValueToCompare="500" Type="Currency"></asp:CompareValidator>
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Effective Date:</div>
        <div class="col-md-8">
            <asp:Calendar ID="EffectiveDate" runat="server"></asp:Calendar>
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Obsolete:</div>
        <div class="col-md-8">
            <asp:RadioButton 
                ID="ObsoleteZero" 
                runat="server" 
                Text="0"
                GroupName="Obsolete" 
                />
            <br />
            <asp:RadioButton 
                ID="ObsoleteOne" 
                runat="server" 
                Text="1" 
                GroupName="Obsolete"
                Checked="True" 
                />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right"></div>
        <div class="col-md-8">
            <asp:Button ID="Update" runat="server" Text="Submit" OnClick="Update_Click" />
        </div>
    </div>
</asp:Content>

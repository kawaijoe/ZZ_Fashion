<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/ProductManager/ProductManager.master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="ZZ_Fashion.LoginPages.ProductManager.UpdateProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Update Products
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row top-padding">
        <div class="col-md-4" align="right">Title:</div>
        <div class="col-md-8">
            <asp:TextBox ID="ProductTitle" runat="server"></asp:TextBox>
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
            <asp:Button ID="UploadFile" runat="server" Text="Upload File" />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right">Price:</div>
        <div class="col-md-8">
            <asp:TextBox ID="Price" runat="server"></asp:TextBox>
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
                ID="ObsoleteTrue" 
                runat="server" 
                Text="True"
                GroupName="Obsolete" 
                />
            <br />
            <asp:RadioButton 
                ID="ObsoleteFalse" 
                runat="server" 
                Text="False" 
                GroupName="Obsolete"
                Checked="True" 
                />
        </div>
    </div>
    <div class="row top-padding">
        <div class="col-md-4" align="right"></div>
        <div class="col-md-8">
            <asp:Button ID="Update" runat="server" Text="Update" />
        </div>
    </div>
</asp:Content>

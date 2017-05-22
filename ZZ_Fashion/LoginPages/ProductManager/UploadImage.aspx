<%@ Page Title="" Language="C#" MasterPageFile="~/LoginPages/ProductManager/ProductManager.master" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="ZZ_Fashion.LoginPages.ProductManager.UploadImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    Upload Image
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>

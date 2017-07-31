<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="ZZ_Fashion.LoginPages.logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log Out</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Logout successful."></asp:Label>
            You will redirect in 5 seconds. If you didnt, 
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">
            click here to redirect.</asp:HyperLink>
        </div>
    </form>
</body>
</html>

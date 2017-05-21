<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Public/Public.master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="ZZ_Fashion.Public.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitle" runat="server">
    About Us
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12" style="padding-top: 5px">
            <div id="map" style="width: 100%; height: 400px;">
            </div>
        </div>
        <div class="row">

            <div class="col-md-6" style="padding-top: 5px; padding-left: 50px;">
                <address>
                    One FF Fashion Way<br />
                    Redmond, WA 98052-6399<br />
                    <abbr title="Phone">P:</abbr>
                    425.555.0100
                </address>
            </div>
            <div class="col-md-6" style="padding-top: 5px; padding-left: 50px;">
                <address>
                    <strong>Support:</strong>   <a href="mailto:Support@ff_fashion.com">Support@example.com</a><br />
                    <strong>Marketing:</strong> <a href="mailto:Marketing@ff_fashion.com">Marketing@example.com</a>
                </address>
            </div>
        </div>

        <script>
            function myMap() {
                var mapOptions = {
                    center: new google.maps.LatLng(51.5, -0.12),
                    zoom: 10,
                    mapTypeId: google.maps.MapTypeId.HYBRID
                }
                var map = new google.maps.Map(document.getElementById("map"), mapOptions);
            }
        </script>

        <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDhOPRsw_tCjH3M7xCTZMzRB6yZk5-P1p8&callback=myMap"></script>
</asp:Content>

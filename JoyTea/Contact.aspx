<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="JoyTea.Contact" %>
<asp:Content ContentPlaceHolderID="mapstyle" runat="server">
    <link href="Style/Mapstyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
            <h2><%: Title %> Us</h2>
            <h3>You can reach us on this address.</h3>
            
            <address>
                Station Road, Edgware   <br />
                London, HAX XXX         <br />
                <abbr title="Mobile"> Mob:  </abbr>
                0747 000 0000
            </address>
            
            <h4>Feel free contact us by phone or e-mail.</h4>
            <address>
                <strong>Support:</strong>   <a href="mailto:Support@joytea.com">Support@joytea.com</a><br />
                <strong>Marketing:</strong> <a href="mailto:Marketing@joytea.com">Marketing@joytea.com</a>
            </address>
            </div>
            <div class="col-md-6">
                <div id="map">

                </div>
                <script>
                    function initMap()
                    {
                        var shop = {lat: 51.614854, lng: -0.275668};
                        var map = new google.maps.Map(document.getElementById('map'), {
                            zoom: 13,
                            center: shop
                            });
                        var marker = new google.maps.Marker({
                            position: shop,
                            map: map
                            });
                    }
                </script>
                <script async defer
                    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyArVaP-qWVPoLTLVWwMdoHODhXEsnpHGds&callback=initMap">
                </script>
            </div>
      </div>
    </div>
</asp:Content>

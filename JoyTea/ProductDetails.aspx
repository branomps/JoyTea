<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="JoyTea.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:FormView ID="productDetail" runat="server" ItemType="JoyTea.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td class="detailstdheight">
                        <img src="TeaImages/<%#:Item.ImagePath%>" alt="<%#:Item.ProductName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td>
                        <span class="detailsheader">
                                Description   
                        </span>
                        <br />
                        <p class="detailstext">
                            <%#:Item.Description %>
                        </p>
                        <br />
                        <span class="detailsheader"><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span class="detailsheader"><b>Product Number:</b>&nbsp;<%#:Item.ProductID %></span>
                        <br />
                         <a class="btnproductdetails" href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span>
                                            <b>add to cart »</b>
                                        </span>           
                        </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

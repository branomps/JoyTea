<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JoyTea._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
        <asp:ListView ID="Default" runat="server" 
                DataKeyNames="ProductID" GroupItemCount="3"
                ItemType="JoyTea.Models.Product" SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td class="productitem"  runat="server">
                        <table class="producttable">
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img class="productimage" src="TeaImages/<%#:Item.ImagePath%>" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td class="productdescription">
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <span class="producttext">
                                            <%#:Item.ProductName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span class="producttext">
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                   <a href="AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                                        <span class="producttext">
                                            <b class="addtocarthome">add to cart »<b>
                                        </span>           
                                    </a>

                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table>
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-4">
            <h2>Stressed Out!</h2>
            <p>
                Stress - we all know it, we’ve all felt it. Sometimes a little stress can push us in a positive way, but more often than not, letting stress build up is damaging to our health! Stress can lead to heart disease, weight gain, and depression.

            </p>
            <p>
                <a class="btnblog" href="https://go.microsoft.com/fwlink/?LinkId=301948">Read more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>FlavorFull Options</h2>
            <p>
                At Tealyra, we pride ourselves in offering a huge variety of tea- we love that we have something for everyone! Now, we recognize that some blends aren’t everyone’s “cup of tea”; that’s why we have hundreds of varieties. 
            </p>
            <p>
                <a class="btnblog" href="https://go.microsoft.com/fwlink/?LinkId=301949">Read more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Beyond Tasty</h2>
            <p>
                Simply the fragrance of a lovely cup of tea featuring cinnamon alerts and warms the soul. Here we’ll take a look into the benefits and healing properties of cinnamon teas. Cinnamon is instantly recognizable; it has a comforting full aroma.
            </p>
            <p>
                <a class="btnblog" href="https://go.microsoft.com/fwlink/?LinkId=301950">Read more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>

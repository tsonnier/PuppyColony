<%@ Page Title="Puppy Colony Main Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IdleGame1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-3">
            <h2>Buildings</h2>

            <asp:ListView ID="buildingList"  
                ItemType="IdleGame1.Models.Building" 
                runat="server"
                SelectMethod="GetBuildings"  >
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
                <ItemTemplate>
                    
                    <b style="font-size: large; font-style: normal">
                        <div id="<%#: Item.Name %>Name"><%#: Item.Name %></div>  <div id="<%#: Item.Name %>Value"><%#: Item.Quantity %></div> <asp:Button ID="<%#: Item.Quantity %>Build" runat="server" Text="Build" Onclick="Build_Click"/>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  <br />  </ItemSeparatorTemplate>
            </asp:ListView>

<%--             <table style="width=100%;border-spacing=15px">
                <tr id="ColHubRow">
                    <td style="padding=15px">
                        Colony Hub
                    </td>
                    <td style="padding=15px" id="ColHubVal">
                        1
                    </td>
                    <td style="padding=15px">
                        <asp:Button ID="Build" runat="server" Text="Build" Onclick="Build_Click"/>
                    </td>
                </tr>
            </table>
    --%>


        </div>
        <div class="col-md-6">
            <h2> Messages</h2>
            <p>
                No messages.
            </p>
        </div>
        <div class="col-md-3">
            <h2>Resources</h2>
<%--
            <asp:ListView ID="ListView1"  
                ItemType="IdleGame1.Models.Resource" 
                runat="server"
                SelectMethod="GetResources" >
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
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <%#: Item.Name %>  <%#: Item.Quantity %>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  <br />  </ItemSeparatorTemplate>
            </asp:ListView>
--%>
        </div>
    </div>

</asp:Content>

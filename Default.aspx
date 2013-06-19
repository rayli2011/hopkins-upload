<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
    

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 23%;
            height: 94px;
            background-color: #CCCCFF;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Login"/>
                    <asp:MenuItem NavigateUrl="~/register.aspx" Text="New Use"/>
                </Items>
            </asp:Menu>
    <asp:Panel ID="Panel1" runat="server" Height="250px">
        <table class="style1">
            <tr>
                <td>Username(Email):<br /> &nbsp;<asp:TextBox ID="username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:<br /> &nbsp;<asp:TextBox ID="passwrod" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br />
        test ...<br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="submit" />
</asp:Panel>
</asp:Content>
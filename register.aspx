<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" MasterPageFile="~/Site.master" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            background-color: #999966;
        }
        .style2
        {
            width: 163px;
            color: #66FFFF;
        }
        .style3
        {
            width: 232px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
            
    <table class="style1">
        <tr>
            <td class="style2">
                user name:</td>
            <td class="style3">
                <asp:TextBox ID="username" runat="server" Width="231px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                password:</td>
            <td >
                <asp:TextBox ID="password" runat="server" Width="231px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                re-password:</td>
            <td class="style3">
                <asp:TextBox ID="repassword" runat="server" Width="231px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Email:</td>
            <td class="style3">
                <asp:TextBox ID="email" runat="server" Width="229px"></asp:TextBox>
            </td>
        </tr>
        </table>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="submitt" />

</asp:Content>
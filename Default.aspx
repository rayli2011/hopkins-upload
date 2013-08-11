<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
    

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 23%;
            height: 201px;
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
                    Password:<br /> &nbsp;<asp:TextBox ID="passwrod"   TextMode="Password" CssClass="password12" runat="server"></asp:TextBox>
                </td>
                <tr>
                  <td>
                      if you are TA please select:
                      <br />
                    <br /> &nbsp;</asp:TextBox>
                      <asp:DropDownList ID="DropDownList1" runat="server" Height="38px" Width="133px">
                          <asp:ListItem Value="2">Login as students</asp:ListItem>
                          <asp:ListItem Value="3">Login as TA</asp:ListItem>
                      </asp:DropDownList>
                </td>
                </tr>
            </tr>
        </table>

        <br />
       <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="submit" />
        
</asp:Panel>
</asp:Content>
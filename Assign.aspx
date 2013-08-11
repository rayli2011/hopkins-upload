<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assign.aspx.cs" Inherits="Assign" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 58%;
            background-color: #CCFF99;
        }
        .style2
        {
            width: 95px;
        }
        .style3
        {
            background-color: #FF66FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="style3">welcome&nbsp;
        </span>
        <asp:Label ID="Label1" runat="server" style="color: #66FFFF" Text="Label" 
            CssClass="style3"></asp:Label>
        <span class="style3">&nbsp;!!!</span><br />
        ---------------------------------------------------------------------------------------<br />
        you already has:<br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataSourceID="SqlDataSource1" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black">
            <EditItemTemplate>
                usrid:
                <asp:Label ID="usridLabel1" runat="server" Text='<%# Eval("usrid") %>' />
                <br />
                username:
                <asp:TextBox ID="usernameTextBox" runat="server" 
                    Text='<%# Bind("username") %>' />
                <br />
                belogntoteach:
                <asp:TextBox ID="belogntoteachTextBox" runat="server" 
                    Text='<%# Bind("belogntoteach") %>' />
                <br />
                catego:
                <asp:TextBox ID="categoTextBox" runat="server" Text='<%# Bind("catego") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <InsertItemTemplate>
                username:
                <asp:TextBox ID="usernameTextBox" runat="server" 
                    Text='<%# Bind("username") %>' />
                <br />
                belogntoteach:
                <asp:TextBox ID="belogntoteachTextBox" runat="server" 
                    Text='<%# Bind("belogntoteach") %>' />
                <br />
                catego:
                <asp:TextBox ID="categoTextBox" runat="server" Text='<%# Bind("catego") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                usrid:
                <asp:Label ID="usridLabel" runat="server" Text='<%# Eval("usrid") %>' />
                <br />
                username:
                <asp:Label ID="usernameLabel" runat="server" Text='<%# Bind("username") %>' />
                <br />
                belogntoteach:
                <asp:Label ID="belogntoteachLabel" runat="server" 
                    Text='<%# Bind("belogntoteach") %>' />
                <br />
                catego:
                <asp:Label ID="categoLabel" runat="server" Text='<%# Bind("catego") %>' />
                <br />

            </ItemTemplate>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
        </asp:FormView>
        <br />
        ----------------------------------------------------------------------------------------<br />
        please assign a TA for your class!<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="191px" 
            DataTextField="username" DataValueField="usrid" 
            onselectedindexchanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" 
            style="background-color: #CCFFFF">
            

        </asp:ListBox>
        <br />
        <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 

            
            SelectCommand="SELECT [username], [belogntoteach], [usrid], [catego] FROM [userinfo] WHERE ([belogntoteach] = @belogntoteach)">
        <selectparameters>
            <asp:SessionParameter Name="belogntoteach" SessionField="userid" Type="Int32" />
        </selectparameters>
       
        </asp:SqlDataSource>
        <br />
        ===========================================================<br />
        <table id="t1" class="style1" visible="false" runat="server">
            <tr>
                <td class="style2">
                    TUID:</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    name:</td>
                <td>
                    <asp:Label ID="name" runat="server" Text="name"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    categorize:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="210px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="assign" />
    &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Log out"  Visible="false" Width="105px" />
    </form>
</body>
</html>

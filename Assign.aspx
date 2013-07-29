<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assign.aspx.cs" Inherits="Assign" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        welcome&nbsp;
        <asp:Label ID="Label1" runat="server" style="color: #66FFFF" Text="Label"></asp:Label>
&nbsp;!!!<br />
        ------------------------------------------------------------------<br />
        you already has:<br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataSourceID="SqlDataSource1">
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
        </asp:FormView>
        <br />
        <br />
        please assign a TA for your class!<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="191px">
            <asp:ListItem Value="">Please select an item</asp:ListItem>

            <asp:ListItem Value="1">Item 1</asp:ListItem>

            <asp:ListItem Value="2">Item 2</asp:ListItem>

        </asp:ListBox>
        <br />
        <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 
            
        
            
            SelectCommand="SELECT [usrid], [username], [belogntoteach], [catego] FROM [userinfo] WHERE ([belogntoteach] = @belogntoteach)">
        <selectparameters>
            <asp:SessionParameter Name="belogntoteach" SessionField="uid" Type="Int32" />
        </selectparameters>
       
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>

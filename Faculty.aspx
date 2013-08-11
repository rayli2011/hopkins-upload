<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Faculty.aspx.cs" Inherits="Faculty" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CC99FF">
    
        this is students&#39; new uploadudents&#39; new upload<br />
        <br />
        <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="at" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        upload by:<asp:Label ID="uploader" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="times" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        your score:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:RadioButtonList 
        ID="RadioButtonList1" runat="server" style="background-color: #CC66FF" 
        Width="214px">
        <asp:ListItem Value="1">1</asp:ListItem>
        <asp:ListItem Value="2">2</asp:ListItem>
        <asp:ListItem Value="3">3</asp:ListItem>
        <asp:ListItem Value="4">4</asp:ListItem>
        <asp:ListItem Value="5">5</asp:ListItem>
        <asp:ListItem Value="6">6</asp:ListItem>
        <asp:ListItem Value="7">7</asp:ListItem>
        <asp:ListItem Value="8">8</asp:ListItem>
        <asp:ListItem Value="9">9</asp:ListItem>
    </asp:RadioButtonList>
        <br />
        your comment:<br />
        <asp:TextBox ID="comments" runat="server" Height="82px" 
            Width="238px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="grade" Width="239px" 
            onclick="Button1_Click" />
        <br />
        
        ------------------------------------------------------------------------------------------</div>
        <div style="background-color: #FFFFCC">
        To Assign to a TA:


        
            <br />
            <br />
            TA-on list:&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" Height="67px" Width="226px"
                 DataTextField="username" DataValueField="usrid">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:connection %>" 
                SelectCommand="SELECT [username],[usrid], [belogntoteach] FROM [userinfo] WHERE ([belogntoteach] = @belogntoteach)">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="scoreing" Name="belogntoteach" 
                        SessionField="scoreing" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <%--Email Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="tinfo" runat="server" Width="230px" Height="16px"></asp:TextBox>
            <br />
            <br />
            Email Boday:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="body" runat="server" Height="53px" Width="228px"></asp:TextBox>--%>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="assign" 
                Width="112px" />
            <br />


        
        </div>
    </form>

</body>
</html>

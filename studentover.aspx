<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentover.aspx.cs" Inherits="studentover" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    this is the information for students&#39; submission:<br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/newload.aspx">new upload?</asp:HyperLink><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="uploaddate" HeaderText="uploaddate" 
                SortExpression="uploaddate" />
            <asp:BoundField DataField="category" HeaderText="category" 
                SortExpression="category" />
            <asp:BoundField DataField="url" HeaderText="url" SortExpression="url" />
            <asp:BoundField DataField="version" HeaderText="version" 
                SortExpression="version" />
            <asp:BoundField DataField="filename" HeaderText="filename" 
                SortExpression="filename" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:connection %>" 
        SelectCommand="SELECT [title],[uploadpersonid], [uploaddate], [category], [url], [version], [filename] FROM [uploadinfo] where uploadpersonid=@userid">
        <selectparameters>
        <asp:SessionParameter Name="userid" SessionField="userid" />
        </selectparameters>
    </asp:SqlDataSource>

    </form>
</body>
</html>

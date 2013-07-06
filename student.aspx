<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="students" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CCCCFF">
    
        <br />
        <br />
        <asp:Button ID="modify" runat="server" Text="modify version!!" 
            onclick="Button1_Click" style="background-color: #999966" Width="140px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="new" runat="server" style="background-color: #666699" 
            Text="New Submit" Width="164px" onclick="Button2_Click" />
        <br />
        <br />
        average score on this article :<asp:Label ID="score" runat="server" ></asp:Label>
        <br />
        <br />
        <br />
        comment:<br />
        ----------------------------------------------------------------------------------------------------------------<br />
    
    </div>
            <asp:DataList ID="DataList1" runat="server" 
            DataSourceID="SqlDataSource1" 
            Width="911px" 
        style="background-color: #FFCCFF">
            <ItemTemplate>
                comments:
                <asp:Label ID="commentsLabel" runat="server" Text='<%# Eval("comments") %>' />
                <br />
                scoredate:
                <asp:Label ID="scoredateLabel" runat="server" Text='<%# Eval("scoredate") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 
            
        SelectCommand="SELECT [comments], [scoredate] FROM [score] WHERE ([uploadingid] = @uploadingid)">
        <selectparameters>
        <asp:SessionParameter Name="uploadingid" SessionField="upid" Type="Int32" />
        </selectparameters>
       
        </asp:SqlDataSource>

    </form>
</body>
</html>

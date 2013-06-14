<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="students" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CCCCFF">
    
        <asp:Label ID="vers" runat="server" Text="lastest version"></asp:Label>
        <br />
        <br />
        <asp:Button ID="modify" runat="server" Text="submit modify version!!" 
            onclick="Button1_Click" style="background-color: #999966" Width="140px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="new" runat="server" style="background-color: #666699" 
            Text="New Submit" Width="164px" onclick="Button2_Click" />
        <br />
        <br />
        average score:<asp:Label ID="score" runat="server" Text="score"></asp:Label>
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
        <table border="2px" cellspacing="2px">
       <tr>
        <td class="style2"> username: <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("comment") %>' /></td>
         <td class="style3"> Date:   <asp:Label ID="dateLabel" Width="200px" runat="server" Text='<%# Eval("scoredate") %>' />
         </td>
       </tr>

        </table>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 
            SelectCommand="SELECT  [comments], [scoredate] FROM [score] where [uploadingid] =@userid  ORDER BY [scoredate]">
        <selectparameters>
        <asp:SessionParameter Name="userid" SessionField="userid" />
        </selectparameters>
       
        </asp:SqlDataSource>

    </form>
</body>
</html>

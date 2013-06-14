<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="teacher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        -------------------------------------------------------------------------------------------
        <asp:DataList 
            ID="DataList1" runat="server" 
            DataSourceID="SqlDataSource1" 
            OnItemCommand="DataList1_ItemCommand" Width="727px" 
            style="background-color: #FFCCFF">
            <ItemTemplate>
        <table border="2px" cellspacing="2px">
       <tr>
        <td class="style2"> author: <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' /></td>
         <td class="style3"> filename： <asp:Label ID="dateLabel" Width="200px" runat="server" Text='<%# Eval("filename") %>' />
         <td class="style3"> Date:   <asp:Label ID="Label1" Width="200px" runat="server" Text='<%# Eval("date") %>' />
         <td class="style3"><asp:LinkButton ID="LinkButton1"  runat = "server" Text = "score" CommandArgument= '<%# DataBinder.Eval(Container.DataItem,"uploadid") %>' CommandName="score"></asp:LinkButton></td></a>
         
         </td>
       </tr>

        </table>
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>

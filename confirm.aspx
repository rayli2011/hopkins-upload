<%@ Page Language="C#" AutoEventWireup="true" CodeFile="confirm.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
         AllowPaging="True" AllowSorting="True" 
        OnRowCommand="GridViewCommandEventHandler" 
        onselectedindexchanged="GridView1_SelectedIndexChanged1">
        <Columns>
          
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="uploaddate" HeaderText="uploaddate" 
                SortExpression="uploaddate" />
            <asp:BoundField DataField="category" HeaderText="category" 
                SortExpression="category" />

            <asp:BoundField DataField="filename" HeaderText="filename" 
                SortExpression="filename" />        
                
     <%--       <asp:ButtonField CommandName="changed" HeaderText="Details" ShowHeader="True" 
                Text="Status" />--%>
             <asp:TemplateField HeaderText="confirm" ShowHeader="False">
              <ItemTemplate>
                <asp:Button ID="btn1" runat="server" CausesValidation="false" Text="confirm" CommandArgument='<%#Eval("uploadid") %>' OnClick="ray2" />
               </ItemTemplate>
            </asp:TemplateField>    
            
    

            
        </Columns>
    </asp:GridView>
    
    <div>
    
        <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>

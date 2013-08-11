<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
           
            border: 1px solid #F0F0F0;
            background-color: #FFCCCC;
        }
        .style2
        {
            width: 163px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" 
        CellPadding="4" ForeColor="#333333" 
            GridLines="None" 
            autopostback="true"  >

        <AlternatingRowStyle BackColor="White" />
        <Columns>
          
            <asp:BoundField DataField="username" HeaderText="name" SortExpression="username" />
            <asp:BoundField DataField="regdate" HeaderText="regdate" 
                SortExpression="regdate" />
            <asp:BoundField DataField="categorise" HeaderText="categorise" 
                SortExpression="categorise" />
            <asp:BoundField DataField="catego" HeaderText="catego" 
                SortExpression="catego" />
             
                
     <%--       <asp:ButtonField CommandName="changed" HeaderText="Details" ShowHeader="True" 
                Text="Status" />--%>

  
  
                       
             <asp:TemplateField HeaderText="sates" ShowHeader="False">
              <ItemTemplate>
                <asp:Button ID="btn1" runat="server" CausesValidation="false" Text="update" CommandArgument='<%#Eval("usrid") %>' OnClick="ray" />
               </ItemTemplate>

            </asp:TemplateField>    
   
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:connection %>" 
        SelectCommand="SELECT [usrid],[username],[regdate], [categorise], [catego] FROM [userinfo] where categorise <> 0 ">
        <selectparameters>
        <asp:SessionParameter Name="userid" SessionField="userid" />
        </selectparameters>
    </asp:SqlDataSource>
        <br />
      
        <br />
        <table id="T1"  runat="server" class="style1" visible="false">
            <tr>
                <td>
                    ID:</td>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    update categorize:</td>
                <td class="style2">
                    <asp:DropDownList ID="FF" runat="server" BorderColor="DarkGray" 
                        BorderStyle="Solid" BorderWidth="1px" Height="16px" Width="225px">
                        <asp:ListItem>Select a Type</asp:ListItem>
                        <asp:ListItem Value="1">Teacher</asp:ListItem>
                        <asp:ListItem Value="2">Student</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td >
                    update range:</td>
                <td class="style2">
            <asp:DropDownList ID="DD" runat="server" BorderColor="DarkGray" Width="225px" 
                        BorderStyle="Solid" BorderWidth="1px" Height="16px">
            <asp:ListItem>Select a categorize</asp:ListItem>
            <asp:ListItem Value="1">DB</asp:ListItem>
            <asp:ListItem Value="1">NWS</asp:ListItem>
            <asp:ListItem Value="3">HCI</asp:ListItem>
            <asp:ListItem Value="4">DB_NWS</asp:ListItem>
            <asp:ListItem Value="5">DB_HCI</asp:ListItem>
            <asp:ListItem Value="6">NWS_HCI</asp:ListItem>
            <asp:ListItem Value="7">DB_NWS_HCI</asp:ListItem>

            </asp:DropDownList>
                    </td>
            </tr>
                 </table>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="update!" 
            Width="104px"  Visible="false"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="sigin out" Width="105px" />
        <br />
        ---------------------------------------------------------------------------------------------------------------<br />
    </div>
    </form>
</body>
</html>

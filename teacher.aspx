<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="teacher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        <div class="style2">
            <strong>below is the list of the article below to your categrize:<br />
            please grade or assign to TA gradute. thanks</strong><br />
        </div>
        <asp:DataList 
            ID="DataList1" runat="server" 
            DataSourceID="SqlDataSource1" 
            Width="727px" 
            style="background-color: #FFCCFF; text-align: left;" 
            onselectedindexchanged="Page_Load" BackColor="White" 
            BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            GridLines="Horizontal" 
            onitemcommand="DataList1_ItemCommand">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>

                title:
                <asp:Label ID="titleLabel" runat="server" Text='<%# Eval("title") %>' />
                <br />
                uploaddate:
                <asp:Label ID="uploaddateLabel" runat="server" 
                    Text='<%# Eval("uploaddate") %>' />
                <br />
                category:
                <asp:Label ID="categoryLabel" runat="server" Text='<%# Eval("category") %>' />
                <br />
                Link to the uploadfile:
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("url") %>' Text='<%# Eval("filename") %>' />
               
                <br />
               <%-- <asp:LinkButton ID="LinkButton1" runat="server" CommandName="grademe" CommandArgument='<%# Eval("uploadid") %>' >grade myself</asp:LinkButton>--%>   
               <asp:LinkButton ID="LinkButton2" runat="server" CommandName="grademe" CommandArgument='<%# Eval("uploadid") %>'>grade!!!!!</asp:LinkButton>
                <br />

            <FooterTemplate>
            <asp:Label Visible='<%#bool.Parse((DataList1.Items.Count==0).ToString())%>' runat="server" ID="lblNoRecord" Text="No Record Found!"></asp:Label>
            </FooterTemplate>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>   &nbsp;
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 
            SelectCommand="SELECT[uploadid],[filename], [title], [abstract], [uploaddate], [category], [url] FROM [uploadinfo] WHERE ([category] = @category) and [uploadid] not in (select uploadingid from score where([scoringid]=@userid))">
            <SelectParameters>
                <asp:SessionParameter Name="category" SessionField="categ" Type="String" />
                   <asp:SessionParameter Name="userid" SessionField="userid" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

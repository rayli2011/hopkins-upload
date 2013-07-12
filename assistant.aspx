<%@ Page Language="C#" AutoEventWireup="true" CodeFile="assistant.aspx.cs" Inherits="assistant" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            GridLines="Vertical" 
            onitemcommand="DataList1_ItemCommand">
            <AlternatingItemStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
            
            <ItemTemplate>
            
                title:
                <asp:Label ID="titleLabel" runat="server" Text='<%# Eval("title") %>' />
                <br />

                  abstract:
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("abstract") %>' />
                <br />
                uploaddate:
                <asp:Label ID="uploaddateLabel" runat="server" 
                    Text='<%# Eval("uploaddate") %>' />

                <br />
                Link to file:
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("url") %>' Text='<%# Eval("filename") %>' />
               
                <br />

               <%-- <asp:LinkButton ID="LinkButton1" runat="server" CommandName="grademe" CommandArgument='<%# Eval("uploadid") %>' >grade myself</asp:LinkButton>--%>   
               <asp:LinkButton ID="LinkButton2" runat="server" CommandName="score" CommandArgument='<%# Eval("uploadid") %>'>score</asp:LinkButton>
                <br />
            </ItemTemplate>
            
            <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        </asp:DataList>   &nbsp;
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connection %>" 
            SelectCommand="SELECT ass.[uploadid],usz.[username],[filename],ass.[assignto],[title], [abstract], [uploaddate], [url]  FROM [uploadinfo] uinfo,[assign] ass,[userinfo] usz  WHERE (ass.[uploadid] = uinfo.[uploadid] ) and ([username]=ass.[assignto]) and (ass.[assignto]=@name)">
            <SelectParameters>
                <asp:SessionParameter Name="name" SessionField="name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
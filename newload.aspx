<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newload.aspx.cs" Inherits="TA"  MasterPageFile="~/Site.master"%>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

    <style type="text/css">
        #T1
        {
            width: 276px;
        }
        #form1
        {
            background-color: #CCFFFF;
        }
        .style1
        {
            text-decoration: underline;
            color: #CC0000;
            font-size: large;
        }
    </style>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <span class="style1"><strong>this is the new uploading form!!!!</strong></span>
    <br />
    <br />
<br />
     
    <asp:FileUpload ID="FileUpload1" runat="server" Height="22px" />
 
    <asp:Label ID="statues" runat="server" Text="Label"></asp:Label>
     <br />
    <br />
     <br />
    title of your file<br />
    <br />
    <asp:TextBox ID="title" runat="server" Height="19px" Width="278px"></asp:TextBox>
     
    <br />
    <br />
    abstract:<br />
    <textarea runat="server" name="abstract" id="T1" rows="5" class=" input_text "></textarea>
     

    <br />
     <br />
     <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" 
        style="background-color: #FFCCCC" Width="272px">
        <asp:ListItem Value="HCI">Human Computer Interaction</asp:ListItem>
        <asp:ListItem Value="NWS">NetWork Security</asp:ListItem>
        <asp:ListItem Value="DB">DataBase</asp:ListItem>
    </asp:DropDownList>
    <br />
     <br />
    <asp:Button runat="server" id="UploadButton" text="Upload" 
        onclick="UploadButton_Click" Height="21px" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
     
  
    </asp:Content>
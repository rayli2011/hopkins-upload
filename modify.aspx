<%@ Page Language="C#" AutoEventWireup="true" CodeFile="modify.aspx.cs"  Inherits="modify" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CCCCFF">


   
    <span class="style1"><strong>please provide modification!</strong></span>
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

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    abstract:<br />
    <textarea runat="server" name="abstract" id="t2" rows="5" class=" input_text "></textarea>
     

    <br />
     <br />
     <br />
    <br />
     <br />
    <asp:Button runat="server" id="UploadButton" text="Update" 
        onclick="UploadButton_Click" Height="21px" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    </form>
   </body>  
  </html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TA.aspx.cs" Inherits="TA" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            background-color: #CCFFCC;
        }
    </style>
</head>
<body style="background-color: #FFFFFF">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" 
            Text="you do not have Assignment to grade"></asp:Label>
        <br />
        ------------------------------------------------------------------------------------------<br />
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="titile"></asp:Label>
    :
    <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
    <br />
    ------------------------------------------------------------------------------------------<br />
    <asp:Label ID="Label3" runat="server" Text="abstract"></asp:Label>
    <br />
    <br />
    <asp:Label ID="abs" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    submit by :
    <asp:Label ID="uploader" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; Date:<asp:Label ID="date" runat="server" Text="Label"></asp:Label>
    <br />
    ------------------------------------------------------------------------------------------<br />
    ------------------------------------------------------------------------------------------<br />
    score:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    comments:<br />
    <asp:TextBox ID="TextBox2" runat="server" Height="59px" Width="239px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click" />
    <br />
    </form>
</body>
</html>

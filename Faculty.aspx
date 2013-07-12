<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Faculty.aspx.cs" Inherits="Faculty" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #CC99FF">
    
        this is students&#39; new uploadudents&#39; new upload<br />
        <br />
        <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="at" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        upload by:<asp:Label ID="uploader" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="times" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        your score:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="score" runat="server"></asp:TextBox>
        <br />
        <br />
        your comment:<asp:TextBox ID="comments" runat="server" Height="82px" 
            Width="238px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="grade" Width="239px" 
            onclick="Button1_Click" />
        <br />
        
        ------------------------------------------------------------------------------------------</div>
        <div style="background-color: #FFFFCC">
        To Assign to a TA:


        
            <br />
            <br />
            TA-username(email):&nbsp;
            <asp:TextBox ID="email" runat="server" Height="16px" 
                Width="224px"></asp:TextBox>
            <br />
            <br />
            Email Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="tinfo" runat="server" Width="230px" Height="16px"></asp:TextBox>
            <br />
            <br />
            Email Boday:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="body" runat="server" Height="53px" Width="228px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="assign" 
                Width="112px" />
            <br />


        
        </div>
    </form>

</body>
</html>

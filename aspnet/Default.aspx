<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server"  Width = "306px"/><br />&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传文件" /><br />
        <asp:Label ID="Label1" runat="server"  Font-Bold = "true" Font-Size = "10pt" ForeColor = " #ff3333" Width = "199px"></asp:Label>
        </div>
        <div>
            <asp:Image ID="Image1" runat="server" Height="207px" Width="299px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="浏览" />
           </div>
         <div>
             <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                 <asp:ListItem Value="0">hah</asp:ListItem>
                 <asp:ListItem Value="1">hello world</asp:ListItem>
                 <asp:ListItem Value="2">world hello</asp:ListItem>
                 <asp:ListItem Value="3"></asp:ListItem>
             </asp:RadioButtonList><br />
             <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" /><br />
             <asp:Label ID="Label2" runat="server" ></asp:Label></div>
    </form>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebUI._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div>
            身高：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            體重：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="計算" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

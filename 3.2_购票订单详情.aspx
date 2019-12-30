<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3.2_购票订单详情.aspx.cs" Inherits="_12._24_exam._3__2_购票订单详情" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            订购详情<br />
            您订购了<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            电影票，为<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            ，共<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            张。<br />
            总计金额<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            元。</div>
    </form>
</body>
</html>

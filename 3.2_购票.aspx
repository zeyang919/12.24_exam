<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3.2_购票.aspx.cs" Inherits="_12._24_exam.购票" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            电影院购票：
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="50">海王</asp:ListItem>
                <asp:ListItem Value="60">毒液</asp:ListItem>
            </asp:RadioButtonList>
            观影日期：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
            张数：<asp:DropDownList ID="DropDownList1" runat="server">
                  <asp:ListItem Value="1">1</asp:ListItem>
                  <asp:ListItem Value="2">2</asp:ListItem>
                  <asp:ListItem Value="3">3</asp:ListItem>                
               </asp:DropDownList><br />
             <asp:Button ID="Button1" runat="server" Text="订购" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

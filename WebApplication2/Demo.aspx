<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApplication2.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("Hello World"); %>
            <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <asp:ListBox ID="lstlocation" runat="server">
            <asp:ListItem>Français</asp:ListItem>
            <asp:ListItem>English</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:RadioButton ID="idhomme" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Homme" />
        </p>
        <asp:RadioButton ID="idfemme" runat="server" Text="Femme" />
        <p>
            <asp:CheckBox ID="chkC" runat="server" Text="C#" />
        </p>
        <asp:CheckBox ID="chkASP" runat="server" Text="ASP.Net" />
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>

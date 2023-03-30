<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="Prac6.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCookies" runat="server"></asp:Label>
            <br />
            <br />
            Enter Value To Store in Cookie:
            <asp:TextBox ID="TextBoxCookie" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnCookie" runat="server" OnClick="BtnClick_Click" Text="Set Cookie" />
        </div>
    </form>
</body>
</html>

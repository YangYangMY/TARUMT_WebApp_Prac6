<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Figure1.aspx.cs" Inherits="Prac6.Figure1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <link id="css" href="<%= (string)Session["SelectedCss"] %>" type="text/css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
        <div>
            You are visitors :
            <asp:Label ID="lblVisitorNum" runat="server"></asp:Label>
            <br />
            You access on
            <asp:Label ID="lblTime" runat="server"></asp:Label>
            <br />
            <br />
            Choose a theme:<br />
            <asp:DropDownList ID="DDLCSS" runat="server">
                <asp:ListItem>Standard</asp:ListItem>
                <asp:ListItem>Special</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="ButtonApply" runat="server" OnClick="ButtonApply_Click" Text="Apply" />
            <br />
            <asp:CheckBox ID="CheckPreference" runat="server" Text="Remember preference" AutoPostBack="True" OnCheckedChanged="CheckPreference_CheckedChanged" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Next Page</asp:LinkButton>
    </form>
</body>
</html>

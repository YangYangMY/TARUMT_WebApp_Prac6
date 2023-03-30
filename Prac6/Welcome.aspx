<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Prac6.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="lblName" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblProgramme" runat="server"></asp:Label>
            <br />
            <br />
            <b><asp:Label ID="lblWelcome" runat="server" ></asp:Label></b>
            <br />
            <br />
            <asp:Label ID="lblCache" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

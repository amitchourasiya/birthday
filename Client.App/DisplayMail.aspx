<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayMail.aspx.cs" Inherits="Client.App.DisplayMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="DisplayMail" runat="server">
        <p>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            &nbsp;
        </p>
        <p>
            <asp:Literal ID="errorMsg" runat="server">
            </asp:Literal>
        </p>
        <asp:Button ID="BtnDisplayMail" runat="server" OnClick="BtnDisplayMail_Click" Text="Show Mail" />
    </form>
</body>
</html>

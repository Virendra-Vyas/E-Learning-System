<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Logout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logout</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblLogout" runat="server" Font-Bold="True" Font-Size="Larger" 
            style="z-index: 1; left: 72px; top: 28px; position: absolute" 
            Text="Logout" Font-Strikeout="False" Font-Underline="True"></asp:Label>
    
    </div>
    <asp:Label ID="lblConfirmation" runat="server" 
        style="z-index: 1; left: 74px; top: 64px; position: absolute" 
        Text="Are you sure you want to logout?"></asp:Label>
    <asp:Button ID="btnYes" runat="server" onclick="btnYes_Click" 
        style="z-index: 1; left: 75px; top: 98px; position: absolute;" 
        Text="Yes" />
    <asp:Button ID="btnNo" runat="server" PostBackUrl="~/UserAccount.aspx" 
        style="z-index: 1; left: 138px; top: 98px; position: absolute" Text="No" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUsername" runat="server" Text="Username:" 
            style="z-index: 1; top: 88px; position: absolute; left: 97px; " width="64"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" 
            style="z-index: 1; left: 181px; top: 88px; position: absolute"></asp:TextBox>
        
        <asp:Label ID="lblPassword" runat="server" Text="Password:" 
            style="z-index: 1; left: 97px; top: 129px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" 
            style="z-index: 1; left: 181px; top: 128px; position: absolute" 
            TextMode="Password"></asp:TextBox>
        
        <asp:Label ID="lblLoginPortal" runat="server" Font-Bold="True" 
            Font-Size="Larger" style="z-index: 1; left: 97px; top: 40px; position: absolute" 
            Text="Login Portal" Font-Underline="True"></asp:Label>
        <p>     
            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                style="z-index: 1; left: 181px; top: 173px; position: absolute" 
                onclick="btnLogin_Click" />      
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 181px; top: 218px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblRegister" runat="server" 
            style="z-index: 1; left: 143px; top: 269px; position: absolute" 
            Text="Student not registered?"></asp:Label>
        
    </div>
    <asp:Button ID="btnRegister" runat="server" 
        style="z-index: 1; left: 293px; top: 260px; position: absolute" 
        Text="Register" PostBackUrl="StudentRegistration.aspx" />
    </form>
</body>
</html>

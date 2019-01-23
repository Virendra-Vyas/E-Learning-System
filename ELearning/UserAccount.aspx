<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserAccount.aspx.cs" Inherits="UserAccount" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Account</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <asp:Button ID="btnLogout" runat="server" PostBackUrl="~/Logout.aspx"        
        style="z-index: 1; left: 27px; top: 29px; position: absolute;" 
        Text="Logout" OnClick="btnLogout_Click" />
    
    <div>
    
        <asp:Label ID="lblUserAccount" runat="server" Font-Bold="True" 
            Font-Size="Larger" Font-Underline="True" 
            style="z-index: 1; left: 119px; top: 69px; position: absolute" 
            Text="User Account"></asp:Label>
    
    </div>
    <asp:Label ID="lblWelcome" runat="server" 
        style="z-index: 1; left: 119px; top: 107px; position: absolute"></asp:Label>
        
    <asp:Label ID="lblTutorChangePassword" runat="server" 
        style="z-index: 1; left: 118px; top: 144px; position: absolute" 
        Text="If this is the first time you have logged in, please change your password."></asp:Label>
        
    <asp:Button ID="btnUpdatePassword" runat="server" 
        style="z-index: 1; top: 29px; position: absolute; left: 280px" 
        Text="Update Password" PostBackUrl="~/UpdatePassword.aspx" />
        
    <asp:Button ID="btnUserDetails" runat="server" 
        PostBackUrl="~/StudentDetails.aspx" 
        style="z-index: 1; left: 120px; top: 29px; position: absolute; right: 531px;" 
        Text="Student Details"/>
        
    <asp:Button ID="btnUpdateTutorCourse" runat="server" 
        style="z-index: 1; left: 457px; top: 30px; position: absolute" 
        Text="Update Tutor Course" Visible="False" 
        PostBackUrl="~/UpdateTutorCourse.aspx" />
        
    
    <asp:Label ID="lblUpdateSuccess" runat="server" ForeColor="#009900" 
        style="z-index: 1; left: 121px; top: 189px; position: absolute"></asp:Label>
        
    
    </form>
</body>
</html>

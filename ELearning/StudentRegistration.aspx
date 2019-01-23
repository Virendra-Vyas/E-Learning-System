<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentRegistration.aspx.cs" Inherits="StudentRegistration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblRegister" runat="server" 
            style="z-index: 1; left: 98px; top: 40px; position: absolute" 
            Text="Student Registration Form" Font-Bold="True" Font-Size="Larger" 
            Font-Underline="True"></asp:Label>
    
    <asp:Label ID="lblUsername" runat="server" 
        style="z-index: 1; left: 102px; top: 77px; position: absolute; height: 19px" 
        Text="Username:"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" 
        style="z-index: 1; left: 103px; top: 111px; position: absolute" 
        Text="Password:"></asp:Label>
    <asp:Label ID="lblConfirmPassword" runat="server" 
        style="z-index: 1; left: 50px; top: 148px; position: absolute" 
        Text="Confirm Password:"></asp:Label>
    <asp:Label ID="lblCourse" runat="server" 
        style="z-index: 1; left: 119px; top: 266px; position: absolute" 
        Text="Course:"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" 
        style="z-index: 1; left: 184px; top: 76px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" 
        style="z-index: 1; left: 184px; top: 111px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtConfirmPassword" runat="server" 
        style="z-index: 1; left: 184px; top: 149px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:DropDownList ID="ddlCourses" runat="server" 
        style="z-index: 1; left: 184px; top: 267px; position: absolute;">
    </asp:DropDownList>
    <asp:Button ID="btnRegister" runat="server" 
        style="z-index: 1; left: 184px; top: 314px; position: absolute" 
        Text="Register" onclick="btnRegister_Click" />
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 184px; top: 360px; position: absolute"></asp:Label>
        <asp:RegularExpressionValidator ID="revalidator" ForeColor="Red" 
            style= "z-index: 1; left: 255px; top: 360px; position: absolute" 
            runat="server" ErrorMessage="Invalid Email Address" ControlToValidate="txtEmailAddress" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
     </div>
    <asp:Label ID="lblRealName" runat="server" 
        style="z-index: 1; left: 100px; top: 186px; position: absolute" 
        Text="Full Name:"></asp:Label>
    <asp:TextBox ID="txtRealName" runat="server" 
        style="z-index: 1; left: 184px; top: 184px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtEmailAddress" runat="server" 
        style="z-index: 1; left: 184px; top: 225px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblEmailAddress" runat="server" 
        style="z-index: 1; left: 75px; top: 226px; position: absolute" 
        Text="Email Address:"></asp:Label>
    </form>
</body>
</html>

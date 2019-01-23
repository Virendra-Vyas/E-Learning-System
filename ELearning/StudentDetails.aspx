<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentDetails.aspx.cs" Inherits="StudentDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Details</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <asp:Button ID="btnUserAccount" runat="server" PostBackUrl="~/UserAccount.aspx" 
        style="z-index: 1; left: 104px; top: 15px; position: absolute" 
        Text="User Account" />
    
    <div>
    
        <asp:Label ID="lblStudentDetails" runat="server" Font-Bold="True" 
            Font-Size="Larger" 
            style="z-index: 1; left: 100px; top: 48px; position: absolute" 
            Text="Student Details" Font-Underline="True"></asp:Label>
    
    </div>
    <asp:Label ID="lblCourse" runat="server" 
        style="z-index: 1; left: 102px; top: 90px; position: absolute" Text="Course:"></asp:Label>
    <asp:TextBox ID="txtCourse" runat="server" ReadOnly="True" 
        style="z-index: 1; left: 165px; top: 87px; position: absolute"></asp:TextBox>
        
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 321px; top: 89px; position: absolute"></asp:Label>
        
    <asp:Label ID="lblTutors" runat="server" 
        style="z-index: 1; left: 102px; top: 125px; position: absolute" 
        Text="Tutor(s) on your course:"></asp:Label>
        
        <asp:ListBox ID="lstTutors" style="z-index: 1; left: 102px; top: 159px; position: absolute; height: 72px; width: 180px" runat="server"></asp:ListBox>
    
    <asp:Button ID="btnShowEmail" runat="server" 
        style="z-index: 1; left: 102px; top: 250px; position: absolute" 
        Text="Show Email" onclick="btnShowEmail_Click" />
    <asp:Label ID="lblEmail" runat="server" Font-Italic="True" 
        style="z-index: 1; left: 236px; top: 254px; position: absolute" 
        Text="Email will appear here."></asp:Label>
        
    <asp:Label ID="lblModules" runat="server" 
        style="z-index: 1; left: 102px; top: 301px; position: absolute" 
        Text="Modules on your course:"></asp:Label>
    
    <div style="z-index: 1; left: 110px; top: 340px; position: absolute;">
    <asp:Repeater ID="rptModules" runat="server">
        <ItemTemplate>
        Module Code:
        <strong>
            <asp:Label ID="lblmodulecode" runat="server" Text='<%#Eval("ModuleCode") %>'></asp:Label></strong><br />
        Module Name:
        <strong>
            <asp:Label ID="lblmodulename" runat="server" Text='<%#Eval("ModuleName") %>'></asp:Label></strong><br />
        </ItemTemplate>
        <SeparatorTemplate>
            <div style="width:300px;"><hr /></div>
        </SeparatorTemplate>
    </asp:Repeater>
    </div>
    
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateTutorCourse.aspx.cs" Inherits="UpdateTutorCourse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Tutor Course</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <asp:UpdateProgress ID="updatep1" runat="server" AssociatedUpdatePanelID="up1">
            <ProgressTemplate>
                <div>
                    <div>
                        &nbsp;<img alt="progress" src="Updading_data.gif" style="height: 239px; width: 246px; margin-left: 523px" />  
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>

     <asp:Button ID="btnUserAccount" runat="server" PostBackUrl="~/UserAccount.aspx" 
        style="z-index: 1; left: 104px; top: 15px; position: absolute" 
        Text="User Account" />
     
     <asp:Label ID="lblRegister" runat="server" 
            style="z-index: 1; left: 102px; top: 56px; position: absolute" 
            Text="Update Tutor Course" Font-Bold="True" Font-Size="Larger" 
            Font-Underline="True"></asp:Label>
     
     <asp:Label ID="lblCourse" runat="server" 
        style="z-index: 1; left: 106px; top: 103px; position: absolute" 
            Text="Current Course:"></asp:Label>
   
     
     <asp:Label ID="lblSwitchToCourse" runat="server" 
        style="z-index: 1; left: 106px; top: 136px; position: absolute" 
        Text="Switch to Course:"></asp:Label>       
     
    <asp:ListBox ID="lstCourses" runat="server"  
        
            
            style="z-index: 1; left: 106px; top: 165px; position: absolute; height: 72px; width: 180px">
    </asp:ListBox>
            <asp:UpdatePanel ID="up1" runat="server">
                <ContentTemplate>
                     <asp:TextBox ID="txtCourse" runat="server" ReadOnly="True" 
        style="z-index: 1; left: 224px; top: 102px; position: absolute"></asp:TextBox>
                    <asp:Button ID="btnUpdateCourse" runat="server" onclick="btnUpdateCourse_Click" 
                        style="z-index: 1; left: 106px; top: 254px; position: absolute" 
                        Text="Update Course" />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
                        style="z-index: 1; left: 106px; top: 294px; position: absolute"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>

         </div>
    </form>
</body>
</html>

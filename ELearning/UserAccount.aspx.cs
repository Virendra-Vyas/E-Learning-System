using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //check if Session has expired or user has not logged in
        if (Session.Count == 0)
        {
            Response.Redirect("~/UserLogin.aspx");
        }
        else
        {
            if (Request.QueryString.HasKeys())
            {
                if (Request.QueryString["change"].Equals("success"))
                {
                    lblUpdateSuccess.Text = "You successfully changed your password";
                }
            }

            if (Page.IsPostBack)
            {
                lblUpdateSuccess.Text = "";
            }

            //retrieve nesseccary session data, casting into variables
            string RealName = (string)Session["RealName"];
            int RoleID = Int32.Parse(Session["RoleID"].ToString());

            //assign the worker's real name to the welcome label
            lblWelcome.Text = "Welcome " + RealName + ".";

            if (RoleID == 1) //i.e. Student
            {
            //    //make student only button visible
                lblTutorChangePassword.Visible = false;
                lblUserAccount.Text = "Student Account";
                
            }

            if (RoleID == 2) //i.e. Tutor
            {
                //make tutor only button visible
                btnUpdateTutorCourse.Visible = true;

                //change Text and PostBack Url properties for tutor
                btnUserDetails.Text = "Tutor Details";
                lblUserAccount.Text = "Tutor Account"; 
                btnUserDetails.PostBackUrl = "~/TutorDetails.aspx";
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //redirect User to the logout page
        Response.Redirect("~/Logout.aspx");
    }
}

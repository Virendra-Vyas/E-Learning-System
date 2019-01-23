using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class UpdatePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session.Count == 0)
        {
            Response.Redirect("~/UserLogin.aspx");
        }
    }

    protected void btnUpdatePassword_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtCurrentPassword.Text.Length < 6)
            {
                lblError.Text = "Current password is invalid length.";
            }
            else if (txtNewPassword.Text.Length < 6)
            {
                lblError.Text = "New password is invalid length.";
            }
            else if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                lblError.Text = "Please confirm new password.";
            }
            else
            {
                Users user = new Users();
                user.UserId = Int32.Parse(Session["UserID"].ToString());

                string password = user.getPasswordUsingID();

                if (password.Equals(txtCurrentPassword.Text))
                {
                    user.UserPassword = txtNewPassword.Text; //UserId already set

                    if (user.updatePasswordByUserId())
                    {
                        System.Threading.Thread.Sleep(4000);
                        Response.Redirect("~/UserAccount.aspx?change=success");
                    }
                    else
                    {
                        lblError.Text = "Database connection error - could not update password";
                    }
                }
            }
        }
        catch
        {
            lblError.Text = "Current password is incorrect";
        }

    }
}
    


using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //validate input before connecting to database
        if (txtUsername.Text.Length < 5 || txtUsername.Text.Length > 20)
        {
            lblError.Text = "Entered username length is not less than 5 or greater than 20 characters";
        }
        else if (txtPassword.Text.Length < 6)
        {
            lblError.Text = "Entered password is not less than 6 characters ";
        }
        else
        {
            try
            {
                Users user = new Users();

                user.UserName = txtUsername.Text;
                user.UserPassword = txtPassword.Text;

                if (user.authenticateUser())
                {


                    Response.Redirect("~/UserAccount.aspx");
                }
            }
            catch
            {
                lblError.Text = "Incorrect username and/or password";
            }
        }
    }
}

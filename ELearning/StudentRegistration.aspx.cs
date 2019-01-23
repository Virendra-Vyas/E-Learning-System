using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

public partial class StudentRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //if request is NOT a post back
            if (!Page.IsPostBack)
            {
                //create instane of middle layer business object
                Courses course = new Courses();
                //retrieve departments from middle layer into a DataTable
                DataTable dt = course.getAllCourses();

                //check if query was successful
                if (dt != null)
                {
                    //set DropDownList's data source to the DataTable
                    ddlCourses.DataSource = dt;
                    //assign DepartmentID database field to the value property
                    ddlCourses.DataValueField = "CourseID";
                    //assign DepartmentName database field to the text property
                    ddlCourses.DataTextField = "CourseName";
                    //bind data
                    ddlCourses.DataBind();
                }
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            //validate input
            if (txtUsername.Text.Length < 5 || txtUsername.Text.Length > 20)
            {
                lblError.Text = "Entered username length is not less than 5 or greater than 20 characters";
            }
            else if (txtPassword.Text.Length < 6)
            {
                lblError.Text = "Password must be at least 6 characters long.";
            }
            else if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                lblError.Text = "Please confirm password.";
            }
            else if (txtRealName.Text.Equals(""))
            {
                lblError.Text = "Please enter your full name.";
            }
            else
            {
                try
                {
                    //create instane of middle layer business object
                    Users user = new Users();

                    //set username property, so it  can be used as a parameter for the query
                    user.UserName = txtUsername.Text;
                    user.EmailAddress = txtEmailAddress.Text;

                    //check if the username exists
                    if (user.userNameExists())
                    {
                        //already exists so output error
                        lblError.Text = "Username already exists, please select another";
                    }
                    else if (user.emailaddressExists())
                    {
                        //already exists so output error
                        lblError.Text = "EmailAddress already exists, please enter another one";
                    }
                    else
                    {
                        //INSERT NEW USER...   

                        //set properties, so it can be used as a parameter for the query
                        user.UserName = txtUsername.Text;
                        user.UserPassword = Encrypt(txtPassword.Text);
                        user.UserPassword = Encrypt(txtPassword.Text);
                        user.RealName = txtRealName.Text;
                        user.EmailAddress = txtEmailAddress.Text;
                        user.RoleId = 1;
                        user.CourseId = Int32.Parse(ddlCourses.SelectedValue);

                        //attempt to add a User and test if it is successful
                        if (user.adduser())
                        {
                            //redirect user to login page
                            Response.Redirect("~/UserLogin.aspx");
                        }
                    }
                }
                catch
                {
                    //exception thrown so display error
                    lblError.Text = "Database connection error - failed to insert record.";
                }

            }
        }
        catch
        {
            //exception thrown so display error
            lblError.Text = "Database connection error - failed to insert record.";
        }
    }

    static string Encrypt(string value)
    {
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(value));
            return Convert.ToBase64String(data);
        }
    }
}


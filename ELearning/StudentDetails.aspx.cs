using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

public partial class StudentDetails : System.Web.UI.Page
{

    //Declare Instance of Middle Class
    Courses course = new Courses();
    Users user = new Users();
    Modules module = new Modules();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //retrieve course from middle layer into a DataTable
            course.CourseId = int.Parse(HttpContext.Current.Session["CourseID"].ToString());
            DataTable dt = course.getsingleCourse();

            user.CourseId = int.Parse(HttpContext.Current.Session["CourseID"].ToString());
            user.RoleId = int.Parse(HttpContext.Current.Session["RoleID"].ToString());
            DataTable dt2 = user.getTutorName(2);


            //check if query was successful
            if (dt != null)
            {
                //set textbox's data source to the DataTable
                //bind data
                txtCourse.Text = dt.Rows[0]["CourseName"].ToString();
            }
            else
            {
                lblError.Text = "Table is null - cannot display Courses.";
            }

            if (dt2 != null)
            {
                //bind data
                lstTutors.DataSource = dt2;
                lstTutors.DataTextField = "RealName";
                lstTutors.DataValueField = "UserID";
                lstTutors.DataBind();

            }
            else
            {
                lblError.Text = "null table cannot display Students.";
            }


            //Binding Modules

            module.CourseId = Int32.Parse(Session["CourseID"].ToString());
            //retrieve Modules from middle layer into a DataTable
            DataTable dt3 = module.bindModules();


            //check if query was successful
            if (dt3 != null)
            {

                //set RepeaterControls's data source to the DataTable
                rptModules.DataSource = dt3;

                //bind data
                rptModules.DataBind();

            }
            else
            {
                lblError.Text = "Database connection error - cannot display .";
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display .";
        }
    }
    protected void btnShowEmail_Click(object sender, EventArgs e)
    {
        try
        {
            string newCourse = lstTutors.SelectedValue;
            if (lstTutors.SelectedValue == "")
            {
                lblEmail.Text = "No tutor selected";
            }
            else
            {
                user.UserId = int.Parse(newCourse);
                lblEmail.Text = user.getTutorEmail();
            }
        }
        catch
        {
            lblError.Text = "Database Error";
        }
    }
}

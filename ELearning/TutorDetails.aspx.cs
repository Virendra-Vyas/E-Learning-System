using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class TutorDetails : System.Web.UI.Page
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
                course.CourseId =  int.Parse(HttpContext.Current.Session["CourseID"].ToString());
                DataTable dt = course.getsingleCourse();

                DataTable dt2 = course.getStudents(1);
               
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
                    lstStudents.DataSource = dt2;

                    lstStudents.DataTextField = "RealName";//bind data

                    lstStudents.DataValueField = "UserID";

                    lstStudents.DataBind();
                    
                }
                else
                {
                    lblError.Text = "null table cannot display Students.";
                }
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }

    }

    protected void btnRemoveStudent_Click(object sender, EventArgs e)
    {
        try
        {
            if (lstStudents.SelectedItem.Text == null)
            {
                lblError.Text = "Select Student to remove";
            }
            else
            {
                Users user = new Users();
                user.UserId = Int32.Parse(lstStudents.SelectedValue);
                //create instane of middle layer business object

                DataTable dt = user.removeStudents();
                if (dt != null)
                {

                    lblSuccess.Text = "Student Successfully Removed";
                    lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
                }

                else
                {
                    lblError.Text = "Datebase Connection Error!!";
                }
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }
    }
}

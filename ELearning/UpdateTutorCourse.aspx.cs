using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class UpdateTutorCourse : System.Web.UI.Page
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
                course.CourseId = int.Parse(HttpContext.Current.Session["CourseID"].ToString());
                DataTable dt = course.getsingleCourse();
                DataTable dt2 = course.getAllCourses();


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
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }

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
                    lstCourses.DataSource = dt;
                    //assign CoursetID database field to the value property
                    lstCourses.DataValueField = "CourseID";
                    //assign CourseName database field to the text property
                    lstCourses.DataTextField = "CourseName";
                    //bind data
                    lstCourses.DataBind();
                }
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }
    }

    protected void btnUpdateCourse_Click(object sender, EventArgs e)
    {
        try
        {
            if (lstCourses.SelectedIndex != -1)
            {
                //create instane of middle layer business object
                Users user = new Users();
                //set property, so it can be used as a parameter for the query
                user.UserId = int.Parse(HttpContext.Current.Session["UserID"].ToString());
                user.CourseId = int.Parse(lstCourses.SelectedValue);
                if (user.updateCourseByUserId())
                {
                    string CourseID = (string)Session["CourseID"];
                    System.Threading.Thread.Sleep(4000);
                    txtCourse.Text = user.getCourseUsingCourseID();
                    lblError.Text = "Course Updated Successfully";
                    lblError.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    //exception thrown so display error
                    lblError.Text = "Database connection error - failed to update record.";
                }
            }


            else
            {
                lblError.Text = "Select a Course to update";
            }
        }
        catch
        {
            lblError.Text = "Database connection error - cannot display Courses.";
        }
    }
 }



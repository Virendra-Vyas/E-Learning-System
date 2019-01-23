using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Courses
/// </summary>
public class Courses
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }

    private DatabaseConnection dataConn;

    public DataTable getAllCourses()
    {
        string command = "Select * FROM Courses";
        return dataConn.executeReader(command);
    }

    public DataTable getsingleCourse()
    {
        string command = "Select CourseName FROM Courses Where CourseID = @course_id ";
        dataConn.addParameter("@course_id", CourseId);
        return dataConn.executeReader(command);
    }

    public DataTable getStudents(int RoleId)
    {
        string command = "Select UserID,RealName FROM Users Where RoleID = @role_id AND CourseID = @course_id";
        dataConn.addParameter("@role_id", RoleId);
        dataConn.addParameter("@course_id", CourseId);
        return dataConn.executeReader(command);
    }
    public Courses()
    {
        dataConn = new DatabaseConnection();
    }

    public DataTable getstudentname()
    {
        string command = "SELECT RealName from Users where CourseID = RoleID";
        return dataConn.executeReader(command);
    }

    public DataTable deleteCourse()
    {
        string command = "Delete from Course WHERE CourseID = @course_id";
        return dataConn.executeReader(command);
    }

    public string getTutorCourseUsingID()
    {
        dataConn.addParameter("@CourseID", CourseId);

        string command = "Select CourseName FROM Course WHERE CourseID=@CourseID";

        DataTable table = dataConn.executeReader(command);

        if (table.Rows.Count > 0)
        {
            return table.Rows[0]["CourseName"].ToString();
        }
        else
        {
            return "";
        }
    }
}
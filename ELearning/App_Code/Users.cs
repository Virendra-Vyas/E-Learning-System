using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{

    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserPassword { get; set; }
    public string RealName { get; set; }
    public string EmailAddress { get; set; }
    public int RoleId { get; set; }
    public int CourseId { get; set; }

    private DatabaseConnection dataConnection;

    public Users()
    {
        dataConnection = new DatabaseConnection();
    }

    public bool userNameExists()
    {
        dataConnection.addParameter("@user_name", UserName);

        string command = "Select COUNT(UserName) FROM Users WHERE UserName=@user_name";

        int result = dataConnection.executeScalar(command); //result of count

        return result > 0 || result == -1; //if record found or exception caught
    }

    public bool emailaddressExists()
    {
        dataConnection.addParameter("@email_address", EmailAddress);

        string command = "Select COUNT(EmailAddress) FROM Users WHERE EmailAddress=@email_address";

        int result = dataConnection.executeScalar(command); //result of count

        return result > 0 || result == -1; //if record found or exception caught
    }

    public bool adduser()
    {
        dataConnection.addParameter("@user_name", UserName);
        dataConnection.addParameter("@User_Password", UserPassword);
        dataConnection.addParameter("@Real_Name", RealName);
        dataConnection.addParameter("@Email_Address", EmailAddress);
        dataConnection.addParameter("@RoleID", RoleId);
        dataConnection.addParameter("@CourseID", CourseId);

        string command = "INSERT INTO Users (UserName, UserPassword, RealName, EmailAddress, RoleID, CourseID) " +
                        "VALUES (@user_name, @user_Password, @Real_Name, @Email_Address, @RoleID, @CourseID)";

        return dataConnection.executeNonQuery(command) > 0; //i.e. 1 or more rows affected
    }

    public bool authenticateUser()
    {
        dataConnection.addParameter("@User_name", UserName);
        dataConnection.addParameter("@User_Password", UserPassword);

        string command = "Select UserID, RealName, RoleID, CourseID FROM Users " +
                        "WHERE UserName=@user_name AND UserPassword=@user_Password";

        DataTable table = dataConnection.executeReader(command);

        if (table.Rows.Count > 0)
        {
            HttpContext.Current.Session["UserID"] = table.Rows[0]["UserID"].ToString();
            HttpContext.Current.Session["RealName"] = table.Rows[0]["RealName"].ToString();
            HttpContext.Current.Session["RoleID"] = table.Rows[0]["RoleID"].ToString();
            HttpContext.Current.Session["CourseID"] = table.Rows[0]["CourseID"].ToString();

            return true;
        }
        else
        {
            return false;
        }
    }

    public string getPasswordUsingID()
    {
        dataConnection.addParameter("@UserID", UserId);

        string command = "Select UserPassword FROM Users WHERE UserID=@userID";

        DataTable table = dataConnection.executeReader(command);

        if (table.Rows.Count > 0)
        {
            return table.Rows[0]["UserPassword"].ToString();
        }
        else
        {
            return "";
        }
    }

    public bool updatePasswordByUserId()
    {
        dataConnection.addParameter("@User_Password", UserPassword);
        dataConnection.addParameter("@UserID", UserId);

        string command = "Update Users Set UserPassword=@User_Password WHERE UserID=@UserID";

        return dataConnection.executeNonQuery(command) > 0; //i.e. 1 or more rows affected
    }


    public DataTable getTutorName(int RoleId)
    {
        string command = "Select UserID,RealName FROM Users Where RoleID = @role_id AND CourseID = @course_id";
        dataConnection.addParameter("@role_id", RoleId);
        dataConnection.addParameter("@course_id", CourseId);
        return dataConnection.executeReader(command);
    }

    public string getTutorEmail()
    {
        dataConnection.addParameter("@UserID", UserId);
        using (DataTable dt = dataConnection.executeReader("SELECT EmailAddress from Users where UserID = @UserID"))
        {
            return dt.Rows[0].ItemArray[0].ToString();
        }
    }

    public string getCourseUsingCourseID()
    {
        dataConnection.addParameter("@CourseID", CourseId);
        // sql command to get the course name
        string command = "Select CourseName FROM Courses WHERE CourseID=@CourseID";
        // execute the sql command
        DataTable table = dataConnection.executeReader(command);
        if (table.Rows.Count > 0)
        {
            return table.Rows[0]["CourseName"].ToString();
        }
        else
        {
            return "";
        }

    }

    public bool updateCourseByUserId()
    {
        // set the parametere values
        dataConnection.addParameter("@CourseID", CourseId);
        dataConnection.addParameter("@UserID", UserId);
        //sql command to update the course name
        string command = "UPDATE Users Set CourseID=@CourseID WHERE UserID=@UserID";
        //execute the sql command
        return dataConnection.executeNonQuery(command) > 0; //i.e. 1 or more rows affected
    }

    public DataTable removeStudents()
    {
        // set the parameter value
        dataConnection.addParameter("@UserID", UserId);
        //sql command to delete the selected student
        string command = "DELETE FROM Users WHERE UserID=@UserID";
        return dataConnection.executeReader(command);
    }
}
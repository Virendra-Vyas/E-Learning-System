using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for CourseModules
/// </summary>
public class CourseModules
{

    public int CourseId { get; set; }
    public int ModuleId { get; set; }

    private DatabaseConnection dataConn;

    public DataTable getAllCourseModules()
    {
        string command = "Select * FROM CourseModules";
        return dataConn.executeReader(command);
    }
    public CourseModules()
    {
        dataConn = new DatabaseConnection();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Modules
/// </summary>
public class Modules
{
    public int ModuleId { get; set; }
    public int CourseId { get; set; }
    public int ModuleCode { get; set; }
    public string ModuleName { get; set; }

    private DatabaseConnection dataConn;

    public DataTable getAllModules()
    {
        string command = "Select * FROM Modules WHERE Course";
        return dataConn.executeReader(command);
    }

    public Modules()
    {
        dataConn = new DatabaseConnection();
    }

    public DataTable bindModules()
    {
        // set the parameter values
        dataConn.addParameter("@CourseID", CourseId);
        // sql command to get the cuisines from the databse         
        string cmd = "select * from Modules where ModuleID in (select ModuleID from CourseModules where CourseID=@CourseID)";
        return dataConn.executeReader(cmd);
    }
}
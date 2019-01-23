using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UserRoles
/// </summary>
public class UserRoles
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }

    private DatabaseConnection dataConn;
    public UserRoles()
    {
        dataConn = new DatabaseConnection();
    }

    public DataTable getAllUserRoles()
    {
        string command = "Select * FROM UserRoles";
        return dataConn.executeReader(command);
    }
}
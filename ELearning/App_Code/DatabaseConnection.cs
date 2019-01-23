using System;
using System.Collections.Generic;
using System.Web;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

/* USE FOR DEBUGGING in Visual Studio - view Output tab */
//System.Diagnostics.Debug.WriteLine("...output...");

public class DatabaseConnection
{

    private static string databaseName = "university.mdf";
    private static string databasePath = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data\\" + databaseName;
    private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + databasePath + ";Integrated Security=True";

    private DbConnection conn;
    private DbCommand comm;
    private List<DbParameter> parameters;

    public DatabaseConnection()
    {
        conn = new SqlConnection(connectionString);
        comm = new SqlCommand();
        comm.Connection = conn;
        parameters = new List<DbParameter>();
    }

    public void addParameter(string name, object value)
    {
        parameters.Add(new SqlParameter(name, value));
    }

    public int executeNonQuery(string command)
    {
        setupSqlCommand(command);

        try
        {
            conn.Open();
            return comm.ExecuteNonQuery();
        }
        catch
        {
            return -1; //failure
        }
        finally
        {
            conn.Close();
        }
    }

    public int executeScalar(string command)
    {    
        setupSqlCommand(command);

        try
        {
            conn.Open();
           
            return (int) comm.ExecuteScalar();
        }
        catch
        { 
            return -1; //failure
        }
        finally
        {   
            conn.Close();
        }
    }

    public DataTable executeReader(string command)
    {
        setupSqlCommand(command);

        DataTable table = new DataTable();

        try
        {
            conn.Open();
            table.Load(comm.ExecuteReader()); //automatically closes the data reader
            return table;
        }
        catch
        {
            return null; //failure
        }
        finally
        {
            conn.Close();
        }
    }

    public DataTable fillDataTable(string command)
    {
        setupSqlCommand(command);

        DataTable table = new DataTable();

        DbDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = comm;

        try
        {
            adapter.Fill(table); // Fill will open and close connection (so long as it hasn't been opened before calling it)

            return table;
        }
        catch
        {
            return null; //failure
        }
    }

    private void setupSqlCommand(string command)
    {
        comm.CommandText = command;
        //comm.CommandType = CommandType.StoredProcedure; //UNCOMMENT IF USING STORED PROCEDURES

        comm.Parameters.Clear(); //clear params from any previously executed command

        foreach (DbParameter dbP in parameters)
        {
            comm.Parameters.Add(dbP);
        }

        parameters.Clear(); //clear list of params ready for next command
    }
}

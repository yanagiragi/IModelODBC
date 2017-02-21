/*--------------------------------------------------------------------------------------+
|
|     $Source: sample/adonet/Model.cs $
|    $RCSfile: Model.cs,v $
|   $Revision: 1.1 $
|       $Date: 2010/06/07 13:13:57 $
|
|  $Copyright: (c) 2014 Bentley Systems, Incorporated. All rights reserved. $
|
+--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Bentley.ODBC.Sample
{
    public class Model 
        {
        private OdbcConnection connection;
        private string fileName;
        public string DBCatagory;

        public Model () {}

        public Model (string fileName)
        {
            this.fileName = fileName;
            ypDumpProperties();
        }
        
        private void ypDumpProperties()
        {
            Data.WriteXml(this.fileName + ".xml");

            try
            {
                Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            // Bad Ways But Works
            // Environment.FailFast("Done");
            // Alternative way :
            // System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        //Demonstrate how to make a connection to i-model
        private OdbcConnection Connection
        {
            get
            {
                if (connection == null)
                    {
                    string connectionString = "DSN=i-model datasource;imodel=" + fileName; // C:\\SimbaEngineSDK_8.0.2.3_bently_preview\\SimbaEngineSDK_8.0.2.3_bently_preview\\Databases\\Text\\PM-Week 16.i.dgn;";
                    connection = new OdbcConnection (connectionString);
                    connection.Open ();
                    }
                return connection;
            }
        }
        
        //Close the connection when we are done
        public void Close ()
        {
            connection.Close ();
        }

        //Setter of i-model file name. Each i-model file is modeled as a database category.
        //The name of the category is a normalized verion of the file name.
        public string FileName
        {
            get {
                return fileName;
            }
            set {
                if (fileName != value) {
                    if (connection != null && connection.State== ConnectionState.Open)
                        connection.Close ();
                    connection = null;
                }
                fileName = value;
            }
        }

        //Demonstrate how to get all the schemas of an i-model
        public List<string> Schemas
        {
            get {
                List<string> schamas = new List<string> ();
                DataTable tables = Connection.GetSchema ("Tables");

                //Get catagory
                if (tables.Rows.Count > 0) {
                    DBCatagory = tables.Rows[0]["TABLE_CAT"] as string;
                }
                foreach (DataRow r in tables.Rows)
                {                    
                    if (!schamas.Contains (r["TABLE_SCHEM"] as string)) {
                        schamas.Add (r["TABLE_SCHEM"] as string);
                    }
                }
                return schamas;
            }
        }

        //Demonstrate how to get all the tables of a given schema
        public List<string> GetTableNames (string schema)
        {
            List<string> retVal = new List<string> ();
            DataTable tables = Connection.GetSchema ("Tables", new string[] { null, schema });

            foreach (DataRow r in tables.Rows)
                retVal.Add (r["TABLE_NAME"] as string);

            return retVal;
        }

        //Get all the fields of a table
        public List<string> GetFields (string schema, string table)
        {
            List<string> retVal = new List<string> ();
            DataTable tables = Connection.GetSchema ("Columns", new string[] { null, schema, table });

            foreach (DataRow r in tables.Rows)
                retVal.Add (r["COL_NAME"] as string);

            return retVal;
        }

        //Using sql statement to get data. Make sure table name it the command text is in the format of "Category.schema.tableName".
        public DataTable GetView (string viewName, string commandstr)
        {
            DataSet ds = new DataSet ();
            ds.EnforceConstraints = false;

            DataTable dt = new DataTable (viewName);
            ds.Tables.Add (dt);
            
            try {
                OdbcCommand command = new OdbcCommand (commandstr, Connection);
                OdbcDataReader reader = command.ExecuteReader ();     //(command, Connection);
                
                dt.Load (reader);
                reader.Close ();
            }
            catch (Exception e)
            {
                MessageBox.Show (e.Message);
            }
            return dt;
        }

        //Retrieve all data from the model
        public DataSet Data
        {
            get {
                string command = "select * from ";
                DataSet retVal = new DataSet ();
                foreach (string schema in Schemas) {
                    List<string> tables = GetTableNames(schema);
                    foreach (string table in tables) {
                        string commandstr = command + DBCatagory + "." + schema + "." + table;
                        OdbcDataAdapter adapter = new OdbcDataAdapter(commandstr, Connection);
                        DataTable dt = new DataTable (table);
                        adapter.Fill (dt);
                        retVal.Tables.Add (dt);
                    }
                }
                return retVal;
            }
       }
    }
}

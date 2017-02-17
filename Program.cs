/*--------------------------------------------------------------------------------------+
|
|     $Source: sample/adonet/Program.cs $
|    $RCSfile: Program.cs,v $
|   $Revision: 1.1 $
|       $Date: 2010/06/07 13:13:57 $
|
|  $Copyright: (c) 2014 Bentley Systems, Incorporated. All rights reserved. $
|
+--------------------------------------------------------------------------------------*/
using System;

namespace Bentley.ODBC.Sample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Model m = new Model("D:\\_Course\\_MicroStation\\Models\\Unit\\pipe\\rd_02.i.dgn");
        }
    }
}

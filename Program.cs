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
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            /*Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new imodelAccessForm ());*/

            imodelAccessForm m = new imodelAccessForm();

            Console.WriteLine("hi");

            return;
            //model = new Model(dialog.FileName);
            //m.dump();

            /*string filename = "D:\\_Course\\_MicroStation\\Models\\Unit\\pipe\\rd_02.i.dgn";
            Model m = new Model(filename);
            Environment.Exit(0);
            //List<String> schemas = m.Schemas;*/

            //string s = Console.ReadLine();
        }
    }
}

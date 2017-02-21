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
using System.IO;

namespace Bentley.ODBC.Sample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main ()
        {
            //Model m = new Model(@"D:\_Course\_MicroStation\Models_Bk\PDS_iModel\UnitComponent\pipe\rd_02.i.dgn");
            ypDumpAttributesToFiles(@"D:\_Course\_MicroStation\Models_Converted\");
        }
        static void ypDumpAttributesToFiles(string imodeldestFolderPath)
        {
            string[] filePaths = Directory.GetFiles(imodeldestFolderPath, "*.i.dgn", SearchOption.AllDirectories);

            for (int i = 0; i < filePaths.Length; ++i)
            {
                Console.WriteLine(filePaths[i]);
                Model m = new Model(filePaths[i]);
            }
        }

    }
}

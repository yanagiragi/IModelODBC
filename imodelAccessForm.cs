/*--------------------------------------------------------------------------------------+
|
|     $Source: sample/adonet/imodelAccessForm.cs $
|    $RCSfile: imodelAccessForm.cs,v $
|   $Revision: 1.1 $
|       $Date: 2010/06/07 13:13:57 $
|
|  $Copyright: (c) 2014 Bentley Systems, Incorporated. All rights reserved. $
|
+--------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bentley.ODBC.Sample
    {
    public partial class imodelAccessForm : Form
        {
        private Model model = null;

        public imodelAccessForm ()
        {
            InitializeComponent ();
            btnSelectFile_Click(null, null);
        }

        ~imodelAccessForm()
        {
            Close();
            Application.Exit();
        }

        private void btnSelectFile_Click (object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog ();
         
            if (dialog.ShowDialog () == DialogResult.OK)
                {
                txtFileName.Text = dialog.FileName;
                model = new Model (dialog.FileName);
                SetupSchemaAndTable ();
                }
        }
        private void SetupSchemaAndTable ()
            {
            if (model != null)
                {
                cboSchema.Items.Clear ();
                
                foreach (string s in model.Schemas)
                    {
                    cboSchema.Items.Add (s);
                    Console.WriteLine(s);
                }
                }
            }

        private void cboSchema_SelectedIndexChanged (object sender, EventArgs e)
            {
            cboTable.Items.Clear ();
            foreach (string s in model.GetTableNames (cboSchema.Text))
                {
                cboTable.Items.Add (s);
                }
            }
        public void dump()
        {
            foreach(string s in model.Schemas)
            {
                Console.WriteLine(s);
            }
        }
        private void btnQuery_Click (object sender, EventArgs e)
            {
            if (model != null)
                {
                
                dataResult.DataSource = model.GetView("Query", txtQuery.Text);
                dataResult.Refresh ();
                }
            }

        private void imodelAccessForm_FormClosing (object sender, FormClosingEventArgs e)
            {
            if (model != null)
                {
                model.Close ();
                }
            }

        private void cboTable_SelectedIndexChanged (object sender, EventArgs e)
            {
            if (model != null)
                {
                txtQuery.Text = "Select * from " + model.DBCatagory + "." + cboSchema.Text + "." + cboTable.Text;
                }
            }

        private void btnOK_Click (object sender, EventArgs e)
            {
            Close ();
            }
       
        }
    }

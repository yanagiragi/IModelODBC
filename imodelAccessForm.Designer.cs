/*--------------------------------------------------------------------------------------+
|
|     $Source: sample/adonet/imodelAccessForm.Designer.cs $
|    $RCSfile: imodelAccessForm.Designer.cs,v $
|   $Revision: 1.1 $
|       $Date: 2010/06/07 13:13:57 $
|
|  $Copyright: (c) 2014 Bentley Systems, Incorporated. All rights reserved. $
|
+--------------------------------------------------------------------------------------*/
namespace Bentley.ODBC.Sample
    {
    partial class imodelAccessForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            this.label1 = new System.Windows.Forms.Label ();
            this.txtFileName = new System.Windows.Forms.TextBox ();
            this.btnSelectFile = new System.Windows.Forms.Button ();
            this.groupBox1 = new System.Windows.Forms.GroupBox ();
            this.btnQuery = new System.Windows.Forms.Button ();
            this.txtQuery = new System.Windows.Forms.TextBox ();
            this.label4 = new System.Windows.Forms.Label ();
            this.cboTable = new System.Windows.Forms.ComboBox ();
            this.label3 = new System.Windows.Forms.Label ();
            this.cboSchema = new System.Windows.Forms.ComboBox ();
            this.label2 = new System.Windows.Forms.Label ();
            this.dataResult = new System.Windows.Forms.DataGridView ();
            this.btnOK = new System.Windows.Forms.Button ();
            this.groupBox1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit ();
            this.SuspendLayout ();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "i-model:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point (70, 18);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size (556, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.Location = new System.Drawing.Point (632, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size (30, 20);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler (this.btnSelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add (this.btnQuery);
            this.groupBox1.Controls.Add (this.txtQuery);
            this.groupBox1.Controls.Add (this.label4);
            this.groupBox1.Controls.Add (this.cboTable);
            this.groupBox1.Controls.Add (this.label3);
            this.groupBox1.Controls.Add (this.cboSchema);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Location = new System.Drawing.Point (12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size (649, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point (519, 80);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size (114, 20);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "Execute Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler (this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point (63, 51);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size (569, 20);
            this.txtQuery.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quey";
            // 
            // cboTable
            // 
            this.cboTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point (378, 22);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size (254, 21);
            this.cboTable.TabIndex = 4;
            this.cboTable.SelectedIndexChanged += new System.EventHandler (this.cboTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (338, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table";
            // 
            // cboSchema
            // 
            this.cboSchema.FormattingEnabled = true;
            this.cboSchema.Location = new System.Drawing.Point (64, 22);
            this.cboSchema.Name = "cboSchema";
            this.cboSchema.Size = new System.Drawing.Size (254, 21);
            this.cboSchema.TabIndex = 2;
            this.cboSchema.SelectedIndexChanged += new System.EventHandler (this.cboSchema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schema";
            // 
            // dataResult
            // 
            this.dataResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult.Location = new System.Drawing.Point (12, 165);
            this.dataResult.Name = "dataResult";
            this.dataResult.ShowCellErrors = false;
            this.dataResult.ShowRowErrors = false;
            this.dataResult.Size = new System.Drawing.Size (649, 466);
            this.dataResult.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point (587, 642);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size (74, 20);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler (this.btnOK_Click);
            // 
            // imodelAccessForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (674, 669);
            this.Controls.Add (this.btnOK);
            this.Controls.Add (this.dataResult);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.btnSelectFile);
            this.Controls.Add (this.txtFileName);
            this.Controls.Add (this.label1);
            this.Name = "imodelAccessForm";
            this.Text = "imodel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler (this.imodelAccessForm_FormClosing);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataResult;
        private System.Windows.Forms.Button btnOK;
        }
    }